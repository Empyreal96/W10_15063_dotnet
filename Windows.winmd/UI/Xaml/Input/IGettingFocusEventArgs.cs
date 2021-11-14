// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IGettingFocusEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(4194679246, 50812, 19432, 143, 212, 196, 77, 103, 135, 126, 13)]
  [ExclusiveTo(typeof (GettingFocusEventArgs))]
  internal interface IGettingFocusEventArgs
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
