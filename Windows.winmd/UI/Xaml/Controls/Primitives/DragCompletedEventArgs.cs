// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.DragCompletedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Composable(typeof (IDragCompletedEventArgsFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public class DragCompletedEventArgs : RoutedEventArgs, IDragCompletedEventArgs
  {
    [MethodImpl]
    public extern DragCompletedEventArgs(
      double horizontalChange,
      double verticalChange,
      bool canceled);

    public extern double HorizontalChange { [MethodImpl] get; }

    public extern double VerticalChange { [MethodImpl] get; }

    public extern bool Canceled { [MethodImpl] get; }
  }
}
