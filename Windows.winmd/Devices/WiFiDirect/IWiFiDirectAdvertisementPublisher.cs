// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.IWiFiDirectAdvertisementPublisher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  [Guid(3009031450, 39711, 17881, 146, 90, 105, 77, 102, 223, 104, 239)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WiFiDirectAdvertisementPublisher))]
  internal interface IWiFiDirectAdvertisementPublisher
  {
    WiFiDirectAdvertisement Advertisement { get; }

    WiFiDirectAdvertisementPublisherStatus Status { get; }

    event TypedEventHandler<WiFiDirectAdvertisementPublisher, WiFiDirectAdvertisementPublisherStatusChangedEventArgs> StatusChanged;

    void Start();

    void Stop();
  }
}
