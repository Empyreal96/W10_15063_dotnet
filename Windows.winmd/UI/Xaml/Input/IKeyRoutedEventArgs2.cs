// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.IKeyRoutedEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Xaml.Input
{
  [WebHostHidden]
  [Guid(453170554, 38452, 20244, 145, 178, 19, 62, 66, 253, 179, 205)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (KeyRoutedEventArgs))]
  internal interface IKeyRoutedEventArgs2
  {
    VirtualKey OriginalKey { get; }
  }
}
