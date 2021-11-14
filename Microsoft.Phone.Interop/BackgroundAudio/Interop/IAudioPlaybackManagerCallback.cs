// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.BackgroundAudio.Interop.IAudioPlaybackManagerCallback
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System.Runtime.InteropServices;

namespace Microsoft.Phone.BackgroundAudio.Interop
{
  [Guid("6732a946-49d4-4d2e-b90d-d9936338936f")]
  [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
  [ComImport]
  internal interface IAudioPlaybackManagerCallback
  {
    void PlayStateChanged(uint NewPlayState);

    void CriticalError(uint hrError);
  }
}
