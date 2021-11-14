// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Input.PointerDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Input
{
  [Static(typeof (IPointerDeviceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.None)]
  [Muse(Version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PointerDevice : IPointerDevice, IPointerDevice2
  {
    public extern PointerDeviceType PointerDeviceType { [MethodImpl] get; }

    public extern bool IsIntegrated { [MethodImpl] get; }

    public extern uint MaxContacts { [MethodImpl] get; }

    public extern Rect PhysicalDeviceRect { [MethodImpl] get; }

    public extern Rect ScreenRect { [MethodImpl] get; }

    public extern IVectorView<PointerDeviceUsage> SupportedUsages { [MethodImpl] get; }

    public extern uint MaxPointersWithZDistance { [MethodImpl] get; }

    [MethodImpl]
    public static extern PointerDevice GetPointerDevice(uint pointerId);

    [MethodImpl]
    public static extern IVectorView<PointerDevice> GetPointerDevices();
  }
}
