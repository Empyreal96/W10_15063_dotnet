// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.InteractionTrackerInertiaStateEnteredArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Composition.Interactions
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class InteractionTrackerInertiaStateEnteredArgs : 
    IInteractionTrackerInertiaStateEnteredArgs
  {
    public extern IReference<Vector3> ModifiedRestingPosition { [MethodImpl] get; }

    public extern IReference<float> ModifiedRestingScale { [MethodImpl] get; }

    public extern Vector3 NaturalRestingPosition { [MethodImpl] get; }

    public extern float NaturalRestingScale { [MethodImpl] get; }

    public extern Vector3 PositionVelocityInPixelsPerSecond { [MethodImpl] get; }

    public extern int RequestId { [MethodImpl] get; }

    public extern float ScaleVelocityInPercentPerSecond { [MethodImpl] get; }
  }
}
