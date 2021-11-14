// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Vpn.IVpnChannelStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Vpn
{
  [Guid(2297103917, 59416, 20477, 152, 166, 54, 62, 55, 54, 201, 93)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IVpnChannelStatics
  {
    void ProcessEventAsync(object thirdPartyPlugIn, object @event);
  }
}
