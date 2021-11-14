// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Lights.Lamp
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI;

namespace Windows.Devices.Lights
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ILampStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class Lamp : ILamp, IClosable
  {
    public extern string DeviceId { [MethodImpl] get; }

    public extern bool IsEnabled { [MethodImpl] get; [MethodImpl] set; }

    public extern float BrightnessLevel { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsColorSettable { [MethodImpl] get; }

    public extern Color Color { [MethodImpl] get; [MethodImpl] set; }

    public extern event TypedEventHandler<Lamp, LampAvailabilityChangedEventArgs> AvailabilityChanged;

    [MethodImpl]
    public extern void Close();

    [MethodImpl]
    public static extern string GetDeviceSelector();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<Lamp> FromIdAsync(string deviceId);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<Lamp> GetDefaultAsync();
  }
}
