// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.DragDeltaEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IDragDeltaEventArgsFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class DragDeltaEventArgs : RoutedEventArgs, IDragDeltaEventArgs
  {
    [MethodImpl]
    public extern DragDeltaEventArgs(double horizontalChange, double verticalChange);

    public extern double HorizontalChange { [MethodImpl] get; }

    public extern double VerticalChange { [MethodImpl] get; }
  }
}
