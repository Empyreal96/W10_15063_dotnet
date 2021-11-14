// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.ISpatialInteractionDetectedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.UI.Input.Spatial
{
  [Guid(123238628, 22881, 15169, 157, 251, 206, 165, 216, 156, 195, 138)]
  [ExclusiveTo(typeof (SpatialInteractionDetectedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ISpatialInteractionDetectedEventArgs
  {
    SpatialInteractionSourceKind InteractionSourceKind { get; }

    SpatialPointerPose TryGetPointerPose(SpatialCoordinateSystem coordinateSystem);

    SpatialInteraction Interaction { get; }
  }
}
