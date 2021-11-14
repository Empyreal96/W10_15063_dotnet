// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IAppBarStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (AppBar))]
  [Guid(2042330765, 56489, 19295, 164, 72, 55, 177, 50, 56, 237, 118)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAppBarStatics
  {
    DependencyProperty IsOpenProperty { get; }

    DependencyProperty IsStickyProperty { get; }
  }
}
