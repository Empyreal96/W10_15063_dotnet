// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.AcceleratorKeyEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Core
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AcceleratorKeyEventArgs : 
    IAcceleratorKeyEventArgs,
    ICoreWindowEventArgs,
    IAcceleratorKeyEventArgs2
  {
    public extern CoreAcceleratorKeyEventType EventType { [MethodImpl] get; }

    public extern VirtualKey VirtualKey { [MethodImpl] get; }

    public extern CorePhysicalKeyStatus KeyStatus { [MethodImpl] get; }

    public extern bool Handled { [MethodImpl] get; [MethodImpl] set; }

    public extern string DeviceId { [MethodImpl] get; }
  }
}
