// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.PointerRoutedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.Input;

namespace Windows.UI.Xaml.Input
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PointerRoutedEventArgs : RoutedEventArgs, IPointerRoutedEventArgs
  {
    public extern Pointer Pointer { [MethodImpl] get; }

    public extern VirtualKeyModifiers KeyModifiers { [MethodImpl] get; }

    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern PointerPoint GetCurrentPoint(UIElement relativeTo);

    [MethodImpl]
    public extern IVector<PointerPoint> GetIntermediatePoints(
      UIElement relativeTo);
  }
}
