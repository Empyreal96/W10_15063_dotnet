// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBarButtonStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2093814758, 21249, 16511, 135, 78, 220, 145, 96, 170, 7, 175)]
  [ExclusiveTo(typeof (AppBarButton))]
  internal interface IAppBarButtonStatics
  {
    DependencyProperty LabelProperty { get; }

    DependencyProperty IconProperty { get; }

    DependencyProperty IsCompactProperty { get; }
  }
}
