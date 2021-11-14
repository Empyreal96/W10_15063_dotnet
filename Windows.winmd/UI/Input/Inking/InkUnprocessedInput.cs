// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkUnprocessedInput
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Input.Inking
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [WebHostHidden]
  public sealed class InkUnprocessedInput : IInkUnprocessedInput
  {
    public extern event TypedEventHandler<InkUnprocessedInput, PointerEventArgs> PointerEntered;

    public extern event TypedEventHandler<InkUnprocessedInput, PointerEventArgs> PointerHovered;

    public extern event TypedEventHandler<InkUnprocessedInput, PointerEventArgs> PointerExited;

    public extern event TypedEventHandler<InkUnprocessedInput, PointerEventArgs> PointerPressed;

    public extern event TypedEventHandler<InkUnprocessedInput, PointerEventArgs> PointerMoved;

    public extern event TypedEventHandler<InkUnprocessedInput, PointerEventArgs> PointerReleased;

    public extern event TypedEventHandler<InkUnprocessedInput, PointerEventArgs> PointerLost;

    public extern InkPresenter InkPresenter { [MethodImpl] get; }
  }
}
