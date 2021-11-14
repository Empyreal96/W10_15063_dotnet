// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IRadialControllerMenu
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [Guid(2231808861, 63040, 17426, 171, 160, 186, 208, 119, 229, 234, 138)]
  [ExclusiveTo(typeof (RadialControllerMenu))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IRadialControllerMenu
  {
    IVector<RadialControllerMenuItem> Items { get; }

    bool IsEnabled { get; set; }

    RadialControllerMenuItem GetSelectedMenuItem();

    void SelectMenuItem(RadialControllerMenuItem menuItem);

    bool TrySelectPreviouslySelectedMenuItem();
  }
}
