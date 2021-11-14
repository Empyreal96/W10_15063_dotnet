// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppService.IAppServiceConnection2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.System.RemoteSystems;

namespace Windows.ApplicationModel.AppService
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AppServiceConnection))]
  [Guid(2346700127, 8962, 20413, 128, 97, 82, 81, 28, 47, 139, 249)]
  internal interface IAppServiceConnection2
  {
    [RemoteAsync]
    IAsyncOperation<AppServiceConnectionStatus> OpenRemoteAsync(
      RemoteSystemConnectionRequest remoteSystemConnectionRequest);

    User User { get; set; }
  }
}
