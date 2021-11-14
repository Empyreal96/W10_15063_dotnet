// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBarButtonStatics3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1299968788, 11998, 17192, 137, 6, 117, 42, 31, 39, 205, 250)]
  [WebHostHidden]
  [ExclusiveTo(typeof (AppBarButton))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAppBarButtonStatics3
  {
    DependencyProperty LabelPositionProperty { get; }

    DependencyProperty IsInOverflowProperty { get; }

    DependencyProperty DynamicOverflowOrderProperty { get; }
  }
}
