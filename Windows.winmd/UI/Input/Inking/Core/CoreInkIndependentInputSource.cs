// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Core.CoreInkIndependentInputSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Input.Inking.Core
{
  [Static(typeof (ICoreInkIndependentInputSourceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CoreInkIndependentInputSource : ICoreInkIndependentInputSource
  {
    public extern event TypedEventHandler<CoreInkIndependentInputSource, PointerEventArgs> PointerEntering;

    public extern event TypedEventHandler<CoreInkIndependentInputSource, PointerEventArgs> PointerHovering;

    public extern event TypedEventHandler<CoreInkIndependentInputSource, PointerEventArgs> PointerExiting;

    public extern event TypedEventHandler<CoreInkIndependentInputSource, PointerEventArgs> PointerPressing;

    public extern event TypedEventHandler<CoreInkIndependentInputSource, PointerEventArgs> PointerMoving;

    public extern event TypedEventHandler<CoreInkIndependentInputSource, PointerEventArgs> PointerReleasing;

    public extern event TypedEventHandler<CoreInkIndependentInputSource, PointerEventArgs> PointerLost;

    public extern InkPresenter InkPresenter { [MethodImpl] get; }

    [MethodImpl]
    public static extern CoreInkIndependentInputSource Create(
      InkPresenter inkPresenter);
  }
}
