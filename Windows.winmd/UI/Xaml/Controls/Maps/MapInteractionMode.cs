// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Maps.MapInteractionMode
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Maps
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum MapInteractionMode
  {
    Auto = 0,
    Disabled = 1,
    GestureOnly = 2,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] PointerAndKeyboard = 2,
    ControlOnly = 3,
    GestureAndControl = 4,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] PointerKeyboardAndControl = 4,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 196608)] PointerOnly = 5,
  }
}
