// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.Thumb
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IThumbStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class Thumb : Control, IThumb
  {
    [MethodImpl]
    public extern Thumb();

    public extern bool IsDragging { [MethodImpl] get; }

    public extern event DragStartedEventHandler DragStarted;

    public extern event DragDeltaEventHandler DragDelta;

    public extern event DragCompletedEventHandler DragCompleted;

    [MethodImpl]
    public extern void CancelDrag();

    public static extern DependencyProperty IsDraggingProperty { [MethodImpl] get; }
  }
}
