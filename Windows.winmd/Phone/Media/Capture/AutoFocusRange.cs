// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Media.Capture.AutoFocusRange
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Media.Capture
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [WebHostHidden]
  [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  public enum AutoFocusRange
  {
    Macro = 1,
    Normal = 2,
    Full = 3,
    Hyperfocal = 4,
    Infinity = 5,
  }
}
