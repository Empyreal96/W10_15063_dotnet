// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.Services.IWiFiDirectServiceRemotePortAddedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Networking;

namespace Windows.Devices.WiFiDirect.Services
{
  [Guid(3570318017, 16339, 20238, 183, 189, 120, 41, 6, 244, 68, 17)]
  [ExclusiveTo(typeof (WiFiDirectServiceRemotePortAddedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWiFiDirectServiceRemotePortAddedEventArgs
  {
    IVectorView<EndpointPair> EndpointPairs { get; }

    WiFiDirectServiceIPProtocol Protocol { get; }
  }
}
