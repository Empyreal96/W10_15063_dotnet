// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Media.Capture.ICameraCapturePropertyRange
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Media.Capture
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (CameraCapturePropertyRange))]
  [WebHostHidden]
  [Guid(2521914935, 2429, 17169, 171, 124, 127, 166, 186, 68, 26, 216)]
  [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  internal interface ICameraCapturePropertyRange
  {
    object Min { [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] [return: Variant] get; }

    object Max { [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] [return: Variant] get; }
  }
}
