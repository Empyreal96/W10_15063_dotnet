// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialInteractionManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Perception;

namespace Windows.UI.Input.Spatial
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ISpatialInteractionManagerStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class SpatialInteractionManager : ISpatialInteractionManager
  {
    public extern event TypedEventHandler<SpatialInteractionManager, SpatialInteractionSourceEventArgs> SourceDetected;

    public extern event TypedEventHandler<SpatialInteractionManager, SpatialInteractionSourceEventArgs> SourceLost;

    public extern event TypedEventHandler<SpatialInteractionManager, SpatialInteractionSourceEventArgs> SourceUpdated;

    public extern event TypedEventHandler<SpatialInteractionManager, SpatialInteractionSourceEventArgs> SourcePressed;

    public extern event TypedEventHandler<SpatialInteractionManager, SpatialInteractionSourceEventArgs> SourceReleased;

    public extern event TypedEventHandler<SpatialInteractionManager, SpatialInteractionDetectedEventArgs> InteractionDetected;

    [MethodImpl]
    public extern IVectorView<SpatialInteractionSourceState> GetDetectedSourcesAtTimestamp(
      PerceptionTimestamp timeStamp);

    [MethodImpl]
    public static extern SpatialInteractionManager GetForCurrentView();
  }
}
