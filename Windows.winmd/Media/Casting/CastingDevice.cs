// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.CastingDevice
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Casting
{
  [Static(typeof (ICastingDeviceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CastingDevice : ICastingDevice
  {
    public extern string Id { [MethodImpl] get; }

    public extern string FriendlyName { [MethodImpl] get; }

    public extern IRandomAccessStreamWithContentType Icon { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<CastingPlaybackTypes> GetSupportedCastingPlaybackTypesAsync();

    [MethodImpl]
    public extern CastingConnection CreateCastingConnection();

    [MethodImpl]
    public static extern string GetDeviceSelector(CastingPlaybackTypes type);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<string> GetDeviceSelectorFromCastingSourceAsync(
      CastingSource castingSource);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<CastingDevice> FromIdAsync(
      string value);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<bool> DeviceInfoSupportsCastingAsync(
      DeviceInformation device);
  }
}
