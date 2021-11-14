// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.ICollectionViewSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [WebHostHidden]
  [ExclusiveTo(typeof (CollectionViewSource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2791969094, 54011, 20141, 190, 159, 53, 120, 164, 102, 220, 254)]
  internal interface ICollectionViewSource
  {
    object Source { get; set; }

    ICollectionView View { get; }

    bool IsSourceGrouped { get; set; }

    PropertyPath ItemsPath { get; set; }
  }
}
