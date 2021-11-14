// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Interop.INotifyCollectionChangedEventArgsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Interop
{
  [Guid(3003924026, 57229, 17573, 154, 56, 122, 192, 208, 140, 230, 61)]
  [WebHostHidden]
  [ExclusiveTo(typeof (NotifyCollectionChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface INotifyCollectionChangedEventArgsFactory
  {
    NotifyCollectionChangedEventArgs CreateInstanceWithAllParameters(
      NotifyCollectionChangedAction action,
      IBindableVector newItems,
      IBindableVector oldItems,
      int newIndex,
      int oldIndex,
      object outer,
      out object inner);
  }
}
