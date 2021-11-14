// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IFocusManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [Guid(2837501793, 56711, 20273, 190, 218, 239, 65, 127, 231, 192, 74)]
  [ExclusiveTo(typeof (FocusManager))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFocusManagerStatics2
  {
    [Overload("TryMoveFocus")]
    bool TryMoveFocus(FocusNavigationDirection focusNavigationDirection);
  }
}
