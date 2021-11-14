// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IVisualInteractionSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input;

namespace Windows.UI.Composition.Interactions
{
  [Guid(3389950598, 55510, 16657, 176, 136, 112, 52, 123, 210, 176, 237)]
  [WebHostHidden]
  [ExclusiveTo(typeof (VisualInteractionSource))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IVisualInteractionSource
  {
    bool IsPositionXRailsEnabled { get; set; }

    bool IsPositionYRailsEnabled { get; set; }

    VisualInteractionSourceRedirectionMode ManipulationRedirectionMode { get; set; }

    InteractionChainingMode PositionXChainingMode { get; set; }

    InteractionSourceMode PositionXSourceMode { get; set; }

    InteractionChainingMode PositionYChainingMode { get; set; }

    InteractionSourceMode PositionYSourceMode { get; set; }

    InteractionChainingMode ScaleChainingMode { get; set; }

    InteractionSourceMode ScaleSourceMode { get; set; }

    Visual Source { get; }

    void TryRedirectForManipulation(PointerPoint pointerPoint);
  }
}
