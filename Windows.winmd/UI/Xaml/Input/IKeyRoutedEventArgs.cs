// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IKeyRoutedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.Core;

namespace Windows.UI.Xaml.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3570220542, 16505, 17129, 163, 154, 48, 149, 211, 240, 73, 198)]
  [ExclusiveTo(typeof (KeyRoutedEventArgs))]
  [WebHostHidden]
  internal interface IKeyRoutedEventArgs
  {
    VirtualKey Key { get; }

    CorePhysicalKeyStatus KeyStatus { get; }

    bool Handled { get; set; }
  }
}
