// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IRadialControllerConfiguration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (RadialControllerConfiguration))]
  [Guid(2797051595, 27218, 17456, 145, 12, 86, 55, 10, 157, 107, 66)]
  internal interface IRadialControllerConfiguration
  {
    void SetDefaultMenuItems(
      IIterable<RadialControllerSystemMenuItemKind> buttons);

    void ResetToDefaultMenuItems();

    bool TrySelectDefaultMenuItem(RadialControllerSystemMenuItemKind type);
  }
}
