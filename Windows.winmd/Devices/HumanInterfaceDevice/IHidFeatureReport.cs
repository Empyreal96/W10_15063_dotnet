// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.IHidFeatureReport
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.HumanInterfaceDevice
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2216532857, 23269, 18147, 130, 239, 31, 236, 92, 137, 66, 244)]
  [ExclusiveTo(typeof (HidFeatureReport))]
  internal interface IHidFeatureReport
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
