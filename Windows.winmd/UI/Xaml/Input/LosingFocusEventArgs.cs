// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.LosingFocusEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  public sealed class LosingFocusEventArgs : RoutedEventArgs, ILosingFocusEventArgs
  {
    public extern DependencyObject OldFocusedElement { [MethodImpl] get; }

    public extern DependencyObject NewFocusedElement { [MethodImpl] get; [MethodImpl] set; }

    public extern FocusState FocusState { [MethodImpl] get; }

    public extern FocusNavigationDirection Direction { [MethodImpl] get; }

    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    public extern FocusInputDeviceKind InputDevice { [MethodImpl] get; }

    public extern bool Cancel { [MethodImpl] get; [MethodImpl] set; }
  }
}
