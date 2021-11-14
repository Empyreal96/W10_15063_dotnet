// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Core.ICoreInkIndependentInputSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Input.Inking.Core
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(968068521, 30265, 17561, 165, 181, 25, 29, 0, 227, 91, 22)]
  [ExclusiveTo(typeof (CoreInkIndependentInputSource))]
  internal interface ICoreInkIndependentInputSource
  {
    event TypedEventHandler<CoreInkIndependentInputSource, PointerEventArgs> PointerEntering;

    event TypedEventHandler<CoreInkIndependentInputSource, PointerEventArgs> PointerHovering;

    event TypedEventHandler<CoreInkIndependentInputSource, PointerEventArgs> PointerExiting;

    event TypedEventHandler<CoreInkIndependentInputSource, PointerEventArgs> PointerPressing;

    event TypedEventHandler<CoreInkIndependentInputSource, PointerEventArgs> PointerMoving;

    event TypedEventHandler<CoreInkIndependentInputSource, PointerEventArgs> PointerReleasing;

    event TypedEventHandler<CoreInkIndependentInputSource, PointerEventArgs> PointerLost;

    InkPresenter InkPresenter { get; }
  }
}
