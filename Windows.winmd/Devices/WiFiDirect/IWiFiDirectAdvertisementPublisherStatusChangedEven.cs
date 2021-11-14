// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.IWiFiDirectAdvertisementPublisherStatusChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  [ExclusiveTo(typeof (WiFiDirectAdvertisementPublisherStatusChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2868766012, 21633, 18150, 144, 221, 50, 17, 101, 24, 241, 146)]
  internal interface IWiFiDirectAdvertisementPublisherStatusChangedEventArgs
  {
    WiFiDirectAdvertisementPublisherStatus Status { get; }

    WiFiDirectError Error { get; }
  }
}
