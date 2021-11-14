// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Navigation.INavigatingCancelEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml.Navigation
{
  [ExclusiveTo(typeof (NavigatingCancelEventArgs))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4246562734, 60155, 16505, 190, 128, 109, 201, 42, 3, 174, 223)]
  internal interface INavigatingCancelEventArgs
  {
    bool Cancel { get; set; }

    NavigationMode NavigationMode { get; }

    TypeName SourcePageType { get; }
  }
}
