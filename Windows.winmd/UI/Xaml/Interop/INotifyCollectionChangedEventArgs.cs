// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Interop.INotifyCollectionChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Interop
{
  [WebHostHidden]
  [Guid(1291226419, 58354, 18788, 184, 94, 148, 91, 79, 126, 47, 33)]
  [ExclusiveTo(typeof (NotifyCollectionChangedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface INotifyCollectionChangedEventArgs
  {
    NotifyCollectionChangedAction Action { get; }

    IBindableVector NewItems { get; }

    IBindableVector OldItems { get; }

    int NewStartingIndex { get; }

    int OldStartingIndex { get; }
  }
}
