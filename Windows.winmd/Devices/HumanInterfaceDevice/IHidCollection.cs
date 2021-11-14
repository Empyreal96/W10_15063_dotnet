// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.IHidCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.HumanInterfaceDevice
{
  [Guid(1904866723, 13041, 18147, 190, 253, 68, 210, 102, 59, 126, 106)]
  [ExclusiveTo(typeof (HidCollection))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHidCollection
  {
    uint Id { get; }

    HidCollectionType Type { get; }

    uint UsagePage { get; }

    uint UsageId { get; }
  }
}
