// Decompiled with JetBrains decompiler
// Type: Windows.Devices.WiFiDirect.WiFiDirectInformationElement
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.WiFiDirect
{
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IWiFiDirectInformationElementStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WiFiDirectInformationElement : IWiFiDirectInformationElement
  {
    [MethodImpl]
    public extern WiFiDirectInformationElement();

    public extern IBuffer Oui { [MethodImpl] get; [MethodImpl] set; }

    public extern byte OuiType { [MethodImpl] get; [MethodImpl] set; }

    public extern IBuffer Value { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public static extern IVector<WiFiDirectInformationElement> CreateFromBuffer(
      IBuffer buffer);

    [MethodImpl]
    public static extern IVector<WiFiDirectInformationElement> CreateFromDeviceInformation(
      DeviceInformation deviceInformation);
  }
}
