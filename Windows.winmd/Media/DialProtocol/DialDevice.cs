// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.DialDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.DialProtocol
{
  [Static(typeof (IDialDeviceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class DialDevice : IDialDevice, IDialDevice2
  {
    public extern string Id { [MethodImpl] get; }

    [MethodImpl]
    public extern DialApp GetDialApp(string appName);

    public extern string FriendlyName { [MethodImpl] get; }

    public extern IRandomAccessStreamReference Thumbnail { [MethodImpl] get; }

    [MethodImpl]
    public static extern string GetDeviceSelector(string appName);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<DialDevice> FromIdAsync(
      string value);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> DeviceInfoSupportsDialAsync(
      DeviceInformation device);
  }
}
