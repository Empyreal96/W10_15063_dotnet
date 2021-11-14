// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.IHidOutputReport
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.HumanInterfaceDevice
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HidOutputReport))]
  [Guid(1657480516, 51350, 17507, 147, 193, 223, 157, 176, 83, 196, 80)]
  internal interface IHidOutputReport
  {
    ushort Id { get; }

    IBuffer Data { get; set; }

    HidBooleanControl GetBooleanControl(ushort usagePage, ushort usageId);

    HidBooleanControl GetBooleanControlByDescription(
      HidBooleanControlDescription controlDescription);

    HidNumericControl GetNumericControl(ushort usagePage, ushort usageId);

    HidNumericControl GetNumericControlByDescription(
      HidNumericControlDescription controlDescription);
  }
}
