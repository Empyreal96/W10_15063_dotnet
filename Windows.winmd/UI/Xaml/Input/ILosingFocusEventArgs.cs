// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.ILosingFocusEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ExclusiveTo(typeof (LosingFocusEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [WebHostHidden]
  [Guid(4193682375, 55177, 18219, 170, 147, 109, 65, 5, 230, 218, 190)]
  internal interface ILosingFocusEventArgs
  {
    DependencyObject OldFocusedElement { get; }

    DependencyObject NewFocusedElement { get; set; }

    FocusState FocusState { get; }

    FocusNavigationDirection Direction { get; }

    bool Handled { get; set; }

    FocusInputDeviceKind InputDevice { get; }

    bool Cancel { get; set; }
  }
}
