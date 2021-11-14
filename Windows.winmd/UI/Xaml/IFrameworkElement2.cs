// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IFrameworkElement2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Data;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (FrameworkElement))]
  [Guid(4052812990, 16938, 18692, 165, 47, 238, 114, 1, 4, 41, 229)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFrameworkElement2
  {
    ElementTheme RequestedTheme { get; set; }

    event TypedEventHandler<FrameworkElement, DataContextChangedEventArgs> DataContextChanged;

    BindingExpression GetBindingExpression(DependencyProperty dp);
  }
}
