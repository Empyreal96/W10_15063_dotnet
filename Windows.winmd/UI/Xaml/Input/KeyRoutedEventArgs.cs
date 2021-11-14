// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.KeyRoutedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;
using Windows.UI.Core;

namespace Windows.UI.Xaml.Input
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  public sealed class KeyRoutedEventArgs : 
    RoutedEventArgs,
    IKeyRoutedEventArgs,
    IKeyRoutedEventArgs2,
    IKeyRoutedEventArgs3
  {
    public extern VirtualKey Key { [MethodImpl] get; }

    public extern CorePhysicalKeyStatus KeyStatus { [MethodImpl] get; }

    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    public extern VirtualKey OriginalKey { [MethodImpl] get; }

    public extern string DeviceId { [MethodImpl] get; }
  }
}
