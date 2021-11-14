// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Media.Capture.H264EncoderProfile
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Media.Capture
{
  [WebHostHidden]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  public enum H264EncoderProfile
  {
    Baseline = 66, // 0x00000042
    Main = 77, // 0x0000004D
    Extended = 88, // 0x00000058
    High = 100, // 0x00000064
    High10 = 110, // 0x0000006E
    ConstrainedBaseline = 256, // 0x00000100
  }
}
