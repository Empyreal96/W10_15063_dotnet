// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Navigation.INavigationFailedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml.Navigation
{
  [Guid(297918455, 14018, 16642, 178, 239, 2, 23, 169, 114, 137, 179)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (NavigationFailedEventArgs))]
  internal interface INavigationFailedEventArgs
  {
    HResult Exception { get; }

    bool Handled { get; set; }

    TypeName SourcePageType { get; }
  }
}
