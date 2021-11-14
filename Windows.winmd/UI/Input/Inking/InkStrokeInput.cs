// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.InkStrokeInput
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Input.Inking
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class InkStrokeInput : IInkStrokeInput
  {
    public extern event TypedEventHandler<InkStrokeInput, PointerEventArgs> StrokeStarted;

    public extern event TypedEventHandler<InkStrokeInput, PointerEventArgs> StrokeContinued;

    public extern event TypedEventHandler<InkStrokeInput, PointerEventArgs> StrokeEnded;

    public extern event TypedEventHandler<InkStrokeInput, PointerEventArgs> StrokeCanceled;

    public extern InkPresenter InkPresenter { [MethodImpl] get; }
  }
}
