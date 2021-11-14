// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ScrollViewerView
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ScrollViewerView : IScrollViewerView
  {
    public extern double HorizontalOffset { [MethodImpl] get; }

    public extern double VerticalOffset { [MethodImpl] get; }

    public extern float ZoomFactor { [MethodImpl] get; }
  }
}
