// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.GipGameControllerProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Gaming.Input.Custom
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772162)]
  [Threading(ThreadingModel.Both)]
  public sealed class GipGameControllerProvider : IGipGameControllerProvider, IGameControllerProvider
  {
    [MethodImpl]
    public extern void SendMessage(
      GipMessageClass messageClass,
      byte messageId,
      byte[] messageBuffer);

    [MethodImpl]
    public extern void SendReceiveMessage(
      GipMessageClass messageClass,
      byte messageId,
      byte[] requestMessageBuffer,
      [Out] byte[] responseMessageBuffer);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperationWithProgress<GipFirmwareUpdateResult, GipFirmwareUpdateProgress> UpdateFirmwareAsync(
      IInputStream firmwareImage);

    public extern GameControllerVersionInfo FirmwareVersionInfo { [MethodImpl] get; }

    public extern ushort HardwareProductId { [MethodImpl] get; }

    public extern ushort HardwareVendorId { [MethodImpl] get; }

    public extern GameControllerVersionInfo HardwareVersionInfo { [MethodImpl] get; }

    public extern bool IsConnected { [MethodImpl] get; }
  }
}
