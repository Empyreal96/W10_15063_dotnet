// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Media.Capture.IFrameAcquiredEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Media.Capture
{
  [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  [Guid(2050560497, 48859, 17295, 186, 101, 247, 167, 53, 204, 94, 84)]
  [ExclusiveTo(typeof (FrameAcquiredEventArgs))]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [WebHostHidden]
  internal interface IFrameAcquiredEventArgs
  {
    uint Index { [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")] get; }
  }
}
