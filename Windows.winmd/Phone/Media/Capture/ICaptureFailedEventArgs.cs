// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Media.Capture.ICaptureFailedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Media.Capture
{
  [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (CaptureFailedEventArgs))]
  [Guid(3045601897, 30595, 18876, 163, 121, 34, 54, 108, 141, 224, 62)]
  [WebHostHidden]
  internal interface ICaptureFailedEventArgs
  {
    uint ErrorCode { [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] get; }
  }
}
