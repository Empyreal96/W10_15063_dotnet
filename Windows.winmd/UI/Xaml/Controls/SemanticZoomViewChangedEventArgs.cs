// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SemanticZoomViewChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SemanticZoomViewChangedEventArgs : ISemanticZoomViewChangedEventArgs
  {
    [MethodImpl]
    public extern SemanticZoomViewChangedEventArgs();

    public extern bool IsSourceZoomedInView { [MethodImpl] get; [MethodImpl] set; }

    public extern SemanticZoomLocation SourceItem { [MethodImpl] get; [MethodImpl] set; }

    public extern SemanticZoomLocation DestinationItem { [MethodImpl] get; [MethodImpl] set; }
  }
}
