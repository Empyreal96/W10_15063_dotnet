// Decompiled with JetBrains decompiler
// Type: RadioApiNativeMethods
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Runtime.InteropServices;
using System.Security;

[SecurityCritical]
internal static class RadioApiNativeMethods
{
  [DllImport("radioapi.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
  internal static extern void MediaApi_TuneRadio(uint region, uint KHz);

  [DllImport("radioapi.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
  internal static extern void MediaApi_EnableRadio(uint powerMode);

  [DllImport("radioapi.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
  internal static extern void MediaApi_GetRadioQuality(out uint currentRssi, out uint maxRssi);

  [DllImport("radioapi.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
  internal static extern void MediaApi_GetRadioFrequency(out uint KHz);

  [DllImport("radioapi.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
  internal static extern void MediaApi_GetRadioEnabled(out uint fEnabled);

  [DllImport("radioapi.dll", CharSet = CharSet.Unicode, PreserveSig = false)]
  internal static extern void MediaApi_GetRadioPlaying(out uint fPlaying);
}
