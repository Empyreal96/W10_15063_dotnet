// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMenuFlyout2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1350335405, 55761, 19461, 157, 75, 205, 168, 222, 154, 178, 66)]
  [WebHostHidden]
  [ExclusiveTo(typeof (MenuFlyout))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMenuFlyout2
  {
    void ShowAt(UIElement targetElement, Point point);
  }
}
