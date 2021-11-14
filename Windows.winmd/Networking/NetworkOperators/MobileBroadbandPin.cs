// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.MobileBroadbandPin
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class MobileBroadbandPin : IMobileBroadbandPin
  {
    public extern MobileBroadbandPinType Type { [MethodImpl] get; }

    public extern MobileBroadbandPinLockState LockState { [MethodImpl] get; }

    public extern MobileBroadbandPinFormat Format { [MethodImpl] get; }

    public extern bool Enabled { [MethodImpl] get; }

    public extern uint MaxLength { [MethodImpl] get; }

    public extern uint MinLength { [MethodImpl] get; }

    public extern uint AttemptsRemaining { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MobileBroadbandPinOperationResult> EnableAsync(
      string currentPin);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MobileBroadbandPinOperationResult> DisableAsync(
      string currentPin);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MobileBroadbandPinOperationResult> EnterAsync(
      string currentPin);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MobileBroadbandPinOperationResult> ChangeAsync(
      string currentPin,
      string newPin);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<MobileBroadbandPinOperationResult> UnblockAsync(
      string pinUnblockKey,
      string newPin);
  }
}
