// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IScreenCaptureStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;
using Windows.Phone;

namespace Windows.Media.Capture
{
  [ExclusiveTo(typeof (ScreenCapture))]
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Guid(3365454768, 51365, 4578, 139, 139, 8, 0, 32, 12, 154, 102)]
  internal interface IScreenCaptureStatics
  {
    ScreenCapture GetForCurrentView();
  }
}
