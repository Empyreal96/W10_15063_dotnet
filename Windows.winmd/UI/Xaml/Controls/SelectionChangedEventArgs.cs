// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.SelectionChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (ISelectionChangedEventArgsFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  public class SelectionChangedEventArgs : RoutedEventArgs, ISelectionChangedEventArgs
  {
    [MethodImpl]
    public extern SelectionChangedEventArgs(
      IVector<object> removedItems,
      IVector<object> addedItems);

    public extern IVector<object> AddedItems { [MethodImpl] get; }

    public extern IVector<object> RemovedItems { [MethodImpl] get; }
  }
}
