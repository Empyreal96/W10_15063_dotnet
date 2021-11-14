// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IWebViewStatics5
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (WebView))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(144750801, 20618, 19896, 151, 239, 15, 165, 5, 225, 158, 194)]
  internal interface IWebViewStatics5
  {
    DependencyProperty XYFocusLeftProperty { get; }

    DependencyProperty XYFocusRightProperty { get; }

    DependencyProperty XYFocusUpProperty { get; }

    DependencyProperty XYFocusDownProperty { get; }
  }
}
