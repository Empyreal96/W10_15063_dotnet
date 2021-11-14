// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.IAppServiceConnection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.AppService
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2647946402, 34591, 19794, 137, 169, 158, 9, 5, 49, 189, 39)]
  [ExclusiveTo(typeof (AppServiceConnection))]
  internal interface IAppServiceConnection : IClosable
  {
    string AppServiceName { get; set; }

    string PackageFamilyName { get; set; }

    [RemoteAsync]
    IAsyncOperation<AppServiceConnectionStatus> OpenAsync();

    [RemoteAsync]
    IAsyncOperation<AppServiceResponse> SendMessageAsync(
      ValueSet message);

    event TypedEventHandler<AppServiceConnection, AppServiceRequestReceivedEventArgs> RequestReceived;

    event TypedEventHandler<AppServiceConnection, AppServiceClosedEventArgs> ServiceClosed;
  }
}
