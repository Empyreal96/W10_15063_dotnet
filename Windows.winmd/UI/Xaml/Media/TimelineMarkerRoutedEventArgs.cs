// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.TimelineMarkerRoutedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public sealed class TimelineMarkerRoutedEventArgs : RoutedEventArgs, ITimelineMarkerRoutedEventArgs
  {
    [MethodImpl]
    public extern TimelineMarkerRoutedEventArgs();

    public extern TimelineMarker Marker { [MethodImpl] get; [MethodImpl] set; }
  }
}
