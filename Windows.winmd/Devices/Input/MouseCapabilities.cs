// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.MouseCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MouseCapabilities : IMouseCapabilities
  {
    [MethodImpl]
    public extern MouseCapabilities();

    public extern int MousePresent { [MethodImpl] get; }

    public extern int VerticalWheelPresent { [MethodImpl] get; }

    public extern int HorizontalWheelPresent { [MethodImpl] get; }

    public extern int SwapButtons { [MethodImpl] get; }

    public extern uint NumberOfButtons { [MethodImpl] get; }
  }
}
