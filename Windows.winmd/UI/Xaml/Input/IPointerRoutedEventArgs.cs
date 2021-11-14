// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IPointerRoutedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.Input;

namespace Windows.UI.Xaml.Input
{
  [ExclusiveTo(typeof (PointerRoutedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3663892234, 38738, 18914, 189, 226, 73, 236, 202, 185, 25, 77)]
  [WebHostHidden]
  internal interface IPointerRoutedEventArgs
  {
    Pointer Pointer { get; }

    VirtualKeyModifiers KeyModifiers { get; }

    bool Handled { get; set; }

    PointerPoint GetCurrentPoint(UIElement relativeTo);

    IVector<PointerPoint> GetIntermediatePoints(UIElement relativeTo);
  }
}
