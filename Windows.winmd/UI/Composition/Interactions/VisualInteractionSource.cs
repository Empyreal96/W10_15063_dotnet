// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.VisualInteractionSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;
using Windows.UI.Input;

namespace Windows.UI.Composition.Interactions
{
  [Static(typeof (IVisualInteractionSourceStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Composable(typeof (IVisualInteractionSourceObjectFactory), CompositionType.Protected, 262144, "Windows.Foundation.UniversalApiContract")]
  public class VisualInteractionSource : 
    CompositionObject,
    IVisualInteractionSource,
    ICompositionInteractionSource,
    IVisualInteractionSource2
  {
    public extern bool IsPositionXRailsEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsPositionYRailsEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern VisualInteractionSourceRedirectionMode ManipulationRedirectionMode { [MethodImpl] get; [MethodImpl] set; }

    public extern InteractionChainingMode PositionXChainingMode { [MethodImpl] get; [MethodImpl] set; }

    public extern InteractionSourceMode PositionXSourceMode { [MethodImpl] get; [MethodImpl] set; }

    public extern InteractionChainingMode PositionYChainingMode { [MethodImpl] get; [MethodImpl] set; }

    public extern InteractionSourceMode PositionYSourceMode { [MethodImpl] get; [MethodImpl] set; }

    public extern InteractionChainingMode ScaleChainingMode { [MethodImpl] get; [MethodImpl] set; }

    public extern InteractionSourceMode ScaleSourceMode { [MethodImpl] get; [MethodImpl] set; }

    public extern Visual Source { [MethodImpl] get; }

    [MethodImpl]
    public extern void TryRedirectForManipulation(PointerPoint pointerPoint);

    public extern Vector3 DeltaPosition { [MethodImpl] get; }

    public extern float DeltaScale { [MethodImpl] get; }

    public extern Vector3 Position { [MethodImpl] get; }

    public extern Vector3 PositionVelocity { [MethodImpl] get; }

    public extern float Scale { [MethodImpl] get; }

    public extern float ScaleVelocity { [MethodImpl] get; }

    [MethodImpl]
    public extern void ConfigureCenterPointXModifiers(
      IIterable<CompositionConditionalValue> conditionalValues);

    [MethodImpl]
    public extern void ConfigureCenterPointYModifiers(
      IIterable<CompositionConditionalValue> conditionalValues);

    [MethodImpl]
    public extern void ConfigureDeltaPositionXModifiers(
      IIterable<CompositionConditionalValue> conditionalValues);

    [MethodImpl]
    public extern void ConfigureDeltaPositionYModifiers(
      IIterable<CompositionConditionalValue> conditionalValues);

    [MethodImpl]
    public extern void ConfigureDeltaScaleModifiers(
      IIterable<CompositionConditionalValue> conditionalValues);

    [MethodImpl]
    public static extern VisualInteractionSource Create(Visual source);
  }
}
