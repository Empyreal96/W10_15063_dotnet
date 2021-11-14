// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.HidCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.HumanInterfaceDevice
{
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class HidCollection : IHidCollection
  {
    public extern uint Id { [MethodImpl] get; }

    public extern HidCollectionType Type { [MethodImpl] get; }

    public extern uint UsagePage { [MethodImpl] get; }

    public extern uint UsageId { [MethodImpl] get; }
  }
}
