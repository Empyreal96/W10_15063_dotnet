// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.IWiFiDirectAdvertisement
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  [Guid(2874219053, 10758, 18849, 165, 132, 97, 67, 92, 121, 5, 166)]
  [ExclusiveTo(typeof (WiFiDirectAdvertisement))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWiFiDirectAdvertisement
  {
    IVector<WiFiDirectInformationElement> InformationElements { get; set; }

    WiFiDirectAdvertisementListenStateDiscoverability ListenStateDiscoverability { get; set; }

    bool IsAutonomousGroupOwnerEnabled { get; set; }

    WiFiDirectLegacySettings LegacySettings { get; }
  }
}
