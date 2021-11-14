// Decompiled with JetBrains decompiler
// Type: Windows.Devices.HumanInterfaceDevice.IHidInputReport
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.HumanInterfaceDevice
{
  [ExclusiveTo(typeof (HidInputReport))]
  [Guid(3277655632, 63463, 20109, 178, 62, 202, 187, 229, 107, 144, 233)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHidInputReport
  {
    ushort Id { get; }

    IBuffer Data { get; }

    IVectorView<HidBooleanControl> ActivatedBooleanControls { get; }

    IVectorView<HidBooleanControl> TransitionedBooleanControls { get; }

    HidBooleanControl GetBooleanControl(ushort usagePage, ushort usageId);

    HidBooleanControl GetBooleanControlByDescription(
      HidBooleanControlDescription controlDescription);

    HidNumericControl GetNumericControl(ushort usagePage, ushort usageId);

    HidNumericControl GetNumericControlByDescription(
      HidNumericControlDescription controlDescription);
  }
}
