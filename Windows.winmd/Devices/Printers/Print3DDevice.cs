// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.Print3DDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Printers
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (PrintersContract), 65536)]
  [Static(typeof (IPrint3DDeviceStatics), 65536, "Windows.Devices.Printers.PrintersContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class Print3DDevice : IPrint3DDevice
  {
    public extern PrintSchema PrintSchema { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<Print3DDevice> FromIdAsync(
      string deviceId);

    [MethodImpl]
    public static extern string GetDeviceSelector();
  }
}
