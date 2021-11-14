// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.IPointerDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  [Guid(2479471356, 60363, 18046, 130, 198, 39, 111, 234, 227, 107, 90)]
  [ExclusiveTo(typeof (PointerDevice))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPointerDevice
  {
    PointerDeviceType PointerDeviceType { get; }

    bool IsIntegrated { get; }

    uint MaxContacts { get; }

    Rect PhysicalDeviceRect { get; }

    Rect ScreenRect { get; }

    IVectorView<PointerDeviceUsage> SupportedUsages { get; }
  }
}
