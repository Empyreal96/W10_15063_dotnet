// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.ICollectionViewSourceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [Guid(389678864, 18095, 19468, 129, 139, 33, 182, 239, 129, 191, 101)]
  [ExclusiveTo(typeof (CollectionViewSource))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICollectionViewSourceStatics
  {
    DependencyProperty SourceProperty { get; }

    DependencyProperty ViewProperty { get; }

    DependencyProperty IsSourceGroupedProperty { get; }

    DependencyProperty ItemsPathProperty { get; }
  }
}
