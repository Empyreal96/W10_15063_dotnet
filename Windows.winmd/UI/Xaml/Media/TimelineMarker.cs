// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.TimelineMarker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Static(typeof (ITimelineMarkerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class TimelineMarker : DependencyObject, ITimelineMarker
  {
    [MethodImpl]
    public extern TimelineMarker();

    public extern TimeSpan Time { [MethodImpl] get; [MethodImpl] set; }

    public extern string Type { [MethodImpl] get; [MethodImpl] set; }

    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty TimeProperty { [MethodImpl] get; }

    public static extern DependencyProperty TypeProperty { [MethodImpl] get; }

    public static extern DependencyProperty TextProperty { [MethodImpl] get; }
  }
}
