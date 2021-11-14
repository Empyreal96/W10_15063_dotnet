// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.HidBooleanControlDescription
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.HumanInterfaceDevice
{
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class HidBooleanControlDescription : 
    IHidBooleanControlDescription,
    IHidBooleanControlDescription2
  {
    public extern uint Id { [MethodImpl] get; }

    public extern ushort ReportId { [MethodImpl] get; }

    public extern HidReportType ReportType { [MethodImpl] get; }

    public extern ushort UsagePage { [MethodImpl] get; }

    public extern ushort UsageId { [MethodImpl] get; }

    public extern IVectorView<HidCollection> ParentCollections { [MethodImpl] get; }

    public extern bool IsAbsolute { [MethodImpl] get; }
  }
}
