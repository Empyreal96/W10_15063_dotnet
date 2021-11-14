// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialNavigationStartedEventArgs
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
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class SpatialNavigationStartedEventArgs : ISpatialNavigationStartedEventArgs
  {
    public extern SpatialInteractionSourceKind InteractionSourceKind { [MethodImpl] get; }

    [MethodImpl]
    public extern SpatialPointerPose TryGetPointerPose(
      SpatialCoordinateSystem coordinateSystem);

    public extern bool IsNavigatingX { [MethodImpl] get; }

    public extern bool IsNavigatingY { [MethodImpl] get; }

    public extern bool IsNavigatingZ { [MethodImpl] get; }
  }
}
