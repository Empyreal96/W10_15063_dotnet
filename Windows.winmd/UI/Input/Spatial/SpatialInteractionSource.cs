// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialInteractionSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Perception;

namespace Windows.UI.Input.Spatial
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public sealed class SpatialInteractionSource : 
    ISpatialInteractionSource,
    ISpatialInteractionSource2
  {
    public extern uint Id { [MethodImpl] get; }

    public extern SpatialInteractionSourceKind Kind { [MethodImpl] get; }

    public extern bool IsPointingSupported { [MethodImpl] get; }

    public extern bool IsMenuSupported { [MethodImpl] get; }

    public extern bool IsGraspSupported { [MethodImpl] get; }

    public extern SpatialInteractionController Controller { [MethodImpl] get; }

    [MethodImpl]
    public extern SpatialInteractionSourceState TryGetStateAtTimestamp(
      PerceptionTimestamp timestamp);
  }
}
