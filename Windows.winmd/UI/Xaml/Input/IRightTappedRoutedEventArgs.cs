﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IRightTappedRoutedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Devices.Input;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1748272797, 31701, 16435, 178, 55, 23, 47, 121, 171, 227, 147)]
  [WebHostHidden]
  [ExclusiveTo(typeof (RightTappedRoutedEventArgs))]
  internal interface IRightTappedRoutedEventArgs
  {
    PointerDeviceType PointerDeviceType { get; }

    bool Handled { get; set; }

    Point GetPosition(UIElement relativeTo);
  }
}
