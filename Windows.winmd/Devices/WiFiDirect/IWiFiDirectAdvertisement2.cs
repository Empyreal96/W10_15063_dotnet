// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.IWiFiDirectAdvertisement2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.WiFiDirect
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (WiFiDirectAdvertisement))]
  [Guid(3076106822, 55318, 18715, 145, 122, 180, 13, 125, 196, 3, 162)]
  internal interface IWiFiDirectAdvertisement2
  {
    IVector<WiFiDirectConfigurationMethod> SupportedConfigurationMethods { get; }
  }
}
