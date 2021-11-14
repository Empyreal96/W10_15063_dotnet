// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.DevicePortal.IDevicePortalConnectionRequestReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web.Http;

namespace Windows.System.Diagnostics.DevicePortal
{
  [ExclusiveTo(typeof (DevicePortalConnectionRequestReceivedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1692065861, 28634, 17497, 158, 189, 236, 206, 34, 227, 133, 89)]
  internal interface IDevicePortalConnectionRequestReceivedEventArgs
  {
    HttpRequestMessage RequestMessage { get; }

    HttpResponseMessage ResponseMessage { get; }
  }
}
