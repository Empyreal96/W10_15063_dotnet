// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.MouseDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  [Static(typeof (IMouseDeviceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Standard)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class MouseDevice : IMouseDevice
  {
    public extern event TypedEventHandler<MouseDevice, MouseEventArgs> MouseMoved;

    [MethodImpl]
    public static extern MouseDevice GetForCurrentView();
  }
}
