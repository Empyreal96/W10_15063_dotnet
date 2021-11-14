// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Navigation.INavigationEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml.Navigation
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3064633396, 26257, 17617, 189, 247, 88, 130, 12, 39, 176, 208)]
  [ExclusiveTo(typeof (NavigationEventArgs))]
  internal interface INavigationEventArgs
  {
    object Content { get; }

    object Parameter { get; }

    TypeName SourcePageType { get; }

    NavigationMode NavigationMode { get; }

    Uri Uri { get; set; }
  }
}
