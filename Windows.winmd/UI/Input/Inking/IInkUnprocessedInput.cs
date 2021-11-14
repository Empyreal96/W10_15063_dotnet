// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkUnprocessedInput
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Input.Inking
{
  [WebHostHidden]
  [Guid(3678684640, 33688, 18721, 172, 59, 171, 151, 140, 91, 162, 86)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (InkUnprocessedInput))]
  internal interface IInkUnprocessedInput
  {
    event TypedEventHandler<InkUnprocessedInput, PointerEventArgs> PointerEntered;

    event TypedEventHandler<InkUnprocessedInput, PointerEventArgs> PointerHovered;

    event TypedEventHandler<InkUnprocessedInput, PointerEventArgs> PointerExited;

    event TypedEventHandler<InkUnprocessedInput, PointerEventArgs> PointerPressed;

    event TypedEventHandler<InkUnprocessedInput, PointerEventArgs> PointerMoved;

    event TypedEventHandler<InkUnprocessedInput, PointerEventArgs> PointerReleased;

    event TypedEventHandler<InkUnprocessedInput, PointerEventArgs> PointerLost;

    InkPresenter InkPresenter { get; }
  }
}
