// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.IHidBooleanControlDescription
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.HumanInterfaceDevice
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HidBooleanControlDescription))]
  [Guid(1637279043, 10712, 18986, 134, 131, 132, 158, 32, 123, 190, 49)]
  internal interface IHidBooleanControlDescription
  {
    uint Id { get; }

    ushort ReportId { get; }

    HidReportType ReportType { get; }

    ushort UsagePage { get; }

    ushort UsageId { get; }

    IVectorView<HidCollection> ParentCollections { get; }
  }
}
