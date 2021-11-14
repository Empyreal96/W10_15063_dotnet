// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.DevicePortal.DevicePortalConnectionRequestReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web.Http;

namespace Windows.System.Diagnostics.DevicePortal
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class DevicePortalConnectionRequestReceivedEventArgs : 
    IDevicePortalConnectionRequestReceivedEventArgs
  {
    public extern HttpRequestMessage RequestMessage { [MethodImpl] get; }

    public extern HttpResponseMessage ResponseMessage { [MethodImpl] get; }
  }
}
