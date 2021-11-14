// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.IHidNumericControlDescription
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.HumanInterfaceDevice
{
  [ExclusiveTo(typeof (HidNumericControlDescription))]
  [Guid(1670209158, 7575, 19573, 146, 127, 95, 245, 139, 160, 94, 50)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHidNumericControlDescription
  {
    uint Id { get; }

    ushort ReportId { get; }

    HidReportType ReportType { get; }

    uint ReportSize { get; }

    uint ReportCount { get; }

    ushort UsagePage { get; }

    ushort UsageId { get; }

    int LogicalMinimum { get; }

    int LogicalMaximum { get; }

    int PhysicalMinimum { get; }

    int PhysicalMaximum { get; }

    uint UnitExponent { get; }

    uint Unit { get; }

    bool IsAbsolute { get; }

    bool HasNull { get; }

    IVectorView<HidCollection> ParentCollections { get; }
  }
}
