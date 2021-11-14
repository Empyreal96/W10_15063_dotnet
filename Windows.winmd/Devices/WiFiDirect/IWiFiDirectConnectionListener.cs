// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.IWiFiDirectConnectionListener
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  [Guid(1771838221, 36115, 20201, 185, 236, 156, 114, 248, 37, 31, 125)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WiFiDirectConnectionListener))]
  internal interface IWiFiDirectConnectionListener
  {
    event TypedEventHandler<WiFiDirectConnectionListener, WiFiDirectConnectionRequestedEventArgs> ConnectionRequested;
  }
}
