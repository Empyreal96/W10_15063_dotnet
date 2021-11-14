// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.DevicePortal.IDevicePortalConnectionStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.AppService;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.DevicePortal
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1270755815, 59833, 17989, 143, 237, 165, 62, 234, 14, 219, 214)]
  [ExclusiveTo(typeof (DevicePortalConnection))]
  internal interface IDevicePortalConnectionStatics
  {
    DevicePortalConnection GetForAppServiceConnection(
      AppServiceConnection appServiceConnection);
  }
}
