// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.IWiFiDirectInformationElement
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.WiFiDirect
{
  [ExclusiveTo(typeof (WiFiDirectInformationElement))]
  [Guid(2952491734, 30395, 18814, 172, 139, 220, 114, 131, 139, 195, 9)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWiFiDirectInformationElement
  {
    IBuffer Oui { get; set; }

    byte OuiType { get; set; }

    IBuffer Value { get; set; }
  }
}
