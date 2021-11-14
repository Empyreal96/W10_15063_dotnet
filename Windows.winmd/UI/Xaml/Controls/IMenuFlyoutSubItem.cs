// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IMenuFlyoutSubItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MenuFlyoutSubItem))]
  [Guid(3845678416, 65068, 17378, 167, 63, 98, 22, 143, 97, 153, 115)]
  [WebHostHidden]
  internal interface IMenuFlyoutSubItem
  {
    IVector<MenuFlyoutItemBase> Items { get; }

    string Text { get; set; }
  }
}
