// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialManipulationUpdatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception.Spatial;

namespace Windows.UI.Input.Spatial
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SpatialManipulationUpdatedEventArgs : ISpatialManipulationUpdatedEventArgs
  {
    public extern SpatialInteractionSourceKind InteractionSourceKind { [MethodImpl] get; }

    [MethodImpl]
    public extern SpatialManipulationDelta TryGetCumulativeDelta(
      SpatialCoordinateSystem coordinateSystem);
  }
}
