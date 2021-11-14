// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.IAppServiceRequestReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  [ExclusiveTo(typeof (AppServiceRequestReceivedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1846682464, 65381, 17582, 158, 69, 133, 127, 228, 24, 6, 129)]
  internal interface IAppServiceRequestReceivedEventArgs
  {
    AppServiceRequest Request { get; }

    AppServiceDeferral GetDeferral();
  }
}
