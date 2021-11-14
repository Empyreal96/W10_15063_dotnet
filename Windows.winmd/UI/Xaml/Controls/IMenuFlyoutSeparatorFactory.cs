// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMenuFlyoutSeparatorFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3243891912, 46135, 17632, 178, 75, 87, 32, 174, 161, 219, 172)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MenuFlyoutSeparator))]
  internal interface IMenuFlyoutSeparatorFactory
  {
    MenuFlyoutSeparator CreateInstance(object outer, out object inner);
  }
}
