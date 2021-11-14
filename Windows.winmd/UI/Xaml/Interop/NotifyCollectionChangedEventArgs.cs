// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Interop.NotifyCollectionChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Interop
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Composable(typeof (INotifyCollectionChangedEventArgsFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  public class NotifyCollectionChangedEventArgs : INotifyCollectionChangedEventArgs
  {
    [MethodImpl]
    public extern NotifyCollectionChangedEventArgs(
      NotifyCollectionChangedAction action,
      IBindableVector newItems,
      IBindableVector oldItems,
      int newIndex,
      int oldIndex);

    public extern NotifyCollectionChangedAction Action { [MethodImpl] get; }

    public extern IBindableVector NewItems { [MethodImpl] get; }

    public extern IBindableVector OldItems { [MethodImpl] get; }

    public extern int NewStartingIndex { [MethodImpl] get; }

    public extern int OldStartingIndex { [MethodImpl] get; }
  }
}
