// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.HoldingRoutedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input;

namespace Windows.UI.Xaml.Input
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HoldingRoutedEventArgs : RoutedEventArgs, IHoldingRoutedEventArgs
  {
    [MethodImpl]
    public extern HoldingRoutedEventArgs();

    public extern PointerDeviceType PointerDeviceType { [MethodImpl] get; }

    public extern HoldingState HoldingState { [MethodImpl] get; }

    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern Point GetPosition(UIElement relativeTo);
  }
}
