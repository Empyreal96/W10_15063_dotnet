// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.FrameworkDispatcher
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Microsoft.Xna.Framework
{
  public static class FrameworkDispatcher
  {
    internal static bool UpdateCalledAtLeastOnce;
    private static List<FrameworkDispatcher.ManagedCallAndArg> pendingCalls = new List<FrameworkDispatcher.ManagedCallAndArg>();
    private static List<FrameworkDispatcher.ManagedCallAndArg> pendingCallsCopy = new List<FrameworkDispatcher.ManagedCallAndArg>();

    public static void Update()
    {
      FrameworkDispatcher.UpdateCalledAtLeastOnce = true;
      FrameworkDispatcher.PollForEvents();
      lock (FrameworkDispatcher.pendingCalls)
      {
        foreach (FrameworkDispatcher.ManagedCallAndArg pendingCall in FrameworkDispatcher.pendingCalls)
          FrameworkDispatcher.pendingCallsCopy.Add(pendingCall);
        FrameworkDispatcher.pendingCalls.Clear();
      }
      foreach (FrameworkDispatcher.ManagedCallAndArg managedCallAndArg in FrameworkDispatcher.pendingCallsCopy)
      {
        switch (managedCallAndArg.ManagedCallType)
        {
          case ManagedCallType.Media_ActiveSongChanged:
            MediaPlayer.OnActiveSongChanged(EventArgs.Empty);
            continue;
          case ManagedCallType.Media_PlayStateChanged:
            MediaPlayer.OnMediaStateChanged(EventArgs.Empty);
            continue;
          case ManagedCallType.System_DeviceChanged:
            FrameworkCallbackLinker.OnStorageDeviceChanged(EventArgs.Empty);
            continue;
          case ManagedCallType.CaptureBufferReady:
            Microphone.AllMicrophones.OnBufferReady(managedCallAndArg.ManagedCallArg);
            continue;
          case ManagedCallType.PlaybackBufferNeeded:
            DynamicSoundEffectInstance.RaiseBufferNeededOnInstance(managedCallAndArg.ManagedCallArg);
            continue;
          default:
            continue;
        }
      }
      FrameworkDispatcher.pendingCallsCopy.Clear();
      SoundEffect.RecycleStoppedFireAndForgetInstances();
    }

    internal static void AddNewPendingCall(ManagedCallType callType, uint arg)
    {
      if (!FrameworkDispatcher.UpdateCalledAtLeastOnce)
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.CallFrameworkDispatcherUpdate));
      lock (FrameworkDispatcher.pendingCalls)
      {
        if (FrameworkDispatcher.IsOncePerUpdateEvent(callType))
        {
          foreach (FrameworkDispatcher.ManagedCallAndArg pendingCall in FrameworkDispatcher.pendingCalls)
          {
            if (pendingCall.IsEqual(callType, arg))
              return;
          }
        }
        FrameworkDispatcher.pendingCalls.Add(new FrameworkDispatcher.ManagedCallAndArg(callType, arg));
      }
    }

    internal static bool IsOncePerUpdateEvent(ManagedCallType type) => type == ManagedCallType.CaptureBufferReady || type == ManagedCallType.Media_ActiveSongChanged || type == ManagedCallType.Media_PlayStateChanged;

    private static void PollForEvents()
    {
    }

    private struct ManagedCallAndArg
    {
      public ManagedCallType ManagedCallType;
      public uint ManagedCallArg;

      public ManagedCallAndArg(ManagedCallType callType, uint arg)
      {
        this.ManagedCallType = callType;
        this.ManagedCallArg = arg;
      }

      public bool IsEqual(ManagedCallType type, uint arg) => type == this.ManagedCallType && (int) arg == (int) this.ManagedCallArg;
    }
  }
}
