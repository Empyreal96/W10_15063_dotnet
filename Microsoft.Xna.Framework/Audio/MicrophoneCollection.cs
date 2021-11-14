// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Audio.MicrophoneCollection
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security;

namespace Microsoft.Xna.Framework.Audio
{
  internal sealed class MicrophoneCollection
  {
    private List<Microphone> allMicrophones = new List<Microphone>();
    private ReadOnlyCollection<Microphone> collection;
    private Microphone defaultMic;

    [SecuritySafeCritical]
    internal MicrophoneCollection()
    {
      this.EnumerateMicrophones();
      this.collection = new ReadOnlyCollection<Microphone>((IList<Microphone>) this.allMicrophones);
    }

    [SecuritySafeCritical]
    ~MicrophoneCollection() => MicrophoneUnsafeNativeMethods.ShutdownCaptureEngine();

    [SecuritySafeCritical]
    public unsafe void EnumerateMicrophones()
    {
      int num = 0;
      Helpers.ThrowExceptionFromErrorCode(MicrophoneUnsafeNativeMethods.GetMicrophoneCount(&num));
      if (num < this.allMicrophones.Count)
        throw new InvalidOperationException();
      for (int count = this.allMicrophones.Count; count < num; ++count)
      {
        uint handle;
        if (MicrophoneUnsafeNativeMethods.CreateMicrophone(count, &handle) == ErrorCodes.Success)
          this.allMicrophones.Add(new Microphone(handle));
      }
    }

    internal ReadOnlyCollection<Microphone> All => this.collection;

    internal Microphone Default
    {
      get
      {
        if (this.defaultMic == null)
          this.SelectDefaultMicrophone();
        return this.defaultMic;
      }
    }

    [SecuritySafeCritical]
    internal void SelectDefaultMicrophone()
    {
      if (this.defaultMic != null || this.collection.Count <= 0)
        return;
      this.defaultMic = this.collection[0];
    }

    internal void OnBufferReady(uint handle)
    {
      for (int index = 0; index < this.allMicrophones.Count; ++index)
      {
        if ((int) this.allMicrophones[index].Handle == (int) handle)
        {
          this.allMicrophones[index].OnBufferReady(EventArgs.Empty);
          break;
        }
      }
    }
  }
}
