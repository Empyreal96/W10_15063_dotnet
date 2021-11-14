// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteractionController
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Haptics;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (SpatialInteractionController))]
  [Guid(1594776483, 2388, 20119, 134, 197, 231, 243, 11, 17, 77, 253)]
  internal interface ISpatialInteractionController
  {
    bool HasTouchpad { get; }

    bool HasThumbstick { get; }

    SimpleHapticsController SimpleHapticsController { get; }

    ushort VendorId { get; }

    ushort ProductId { get; }

    ushort Version { get; }
  }
}
