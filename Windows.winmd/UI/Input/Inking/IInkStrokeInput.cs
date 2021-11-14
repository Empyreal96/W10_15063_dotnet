// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkStrokeInput
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Input.Inking
{
  [ExclusiveTo(typeof (InkStrokeInput))]
  [Guid(3476029051, 24080, 17350, 160, 128, 136, 242, 110, 29, 198, 125)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IInkStrokeInput
  {
    event TypedEventHandler<InkStrokeInput, PointerEventArgs> StrokeStarted;

    event TypedEventHandler<InkStrokeInput, PointerEventArgs> StrokeContinued;

    event TypedEventHandler<InkStrokeInput, PointerEventArgs> StrokeEnded;

    event TypedEventHandler<InkStrokeInput, PointerEventArgs> StrokeCanceled;

    InkPresenter InkPresenter { get; }
  }
}
