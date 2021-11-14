// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Navigation;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3300028533, 58945, 17726, 130, 77, 1, 47, 199, 207, 149, 207)]
  [ExclusiveTo(typeof (Page))]
  internal interface IPage
  {
    Frame Frame { get; }

    NavigationCacheMode NavigationCacheMode { get; set; }

    AppBar TopAppBar { get; set; }

    AppBar BottomAppBar { get; set; }
  }
}
