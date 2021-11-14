// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteractionControllerProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Spatial
{
  [ExclusiveTo(typeof (SpatialInteractionControllerProperties))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1627746225, 31657, 20021, 185, 63, 146, 114, 203, 169, 178, 139)]
  internal interface ISpatialInteractionControllerProperties
  {
    bool IsTouchpadTouched { get; }

    bool IsTouchpadPressed { get; }

    bool IsThumbstickPressed { get; }

    double ThumbstickX { get; }

    double ThumbstickY { get; }

    double TouchpadX { get; }

    double TouchpadY { get; }
  }
}
