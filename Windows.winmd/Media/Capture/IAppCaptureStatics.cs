// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IAppCaptureStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Guid(4179811692, 2686, 20084, 139, 32, 156, 31, 144, 45, 8, 161)]
  [ExclusiveTo(typeof (AppCapture))]
  internal interface IAppCaptureStatics
  {
    AppCapture GetForCurrentView();
  }
}
