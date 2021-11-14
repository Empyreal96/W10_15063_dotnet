// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Info.MediaCapabilitiesNativeMethods
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Info
{
  [SecurityCritical]
  internal static class MediaCapabilitiesNativeMethods
  {
    [DllImport("PlatformInterop.dll", EntryPoint = "NativeCanPlayMultiResVideo", PreserveSig = false)]
    internal static extern bool CanPlayMultiResVideo(out bool CanPlay);
  }
}
