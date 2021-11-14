// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.IButtonBase
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ButtonBase))]
  [Guid(4194315290, 18766, 18127, 145, 212, 225, 74, 141, 121, 134, 116)]
  internal interface IButtonBase
  {
    ClickMode ClickMode { get; set; }

    bool IsPointerOver { get; }

    bool IsPressed { get; }

    ICommand Command { get; set; }

    object CommandParameter { get; set; }

    event RoutedEventHandler Click;
  }
}
