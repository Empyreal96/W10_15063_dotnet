// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandPin
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (MobileBroadbandPin))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3865171721, 59257, 17855, 130, 129, 117, 50, 61, 249, 227, 33)]
  internal interface IMobileBroadbandPin
  {
    MobileBroadbandPinType Type { get; }

    MobileBroadbandPinLockState LockState { get; }

    MobileBroadbandPinFormat Format { get; }

    bool Enabled { get; }

    uint MaxLength { get; }

    uint MinLength { get; }

    uint AttemptsRemaining { get; }

    [RemoteAsync]
    IAsyncOperation<MobileBroadbandPinOperationResult> EnableAsync(
      string currentPin);

    [RemoteAsync]
    IAsyncOperation<MobileBroadbandPinOperationResult> DisableAsync(
      string currentPin);

    [RemoteAsync]
    IAsyncOperation<MobileBroadbandPinOperationResult> EnterAsync(
      string currentPin);

    [RemoteAsync]
    IAsyncOperation<MobileBroadbandPinOperationResult> ChangeAsync(
      string currentPin,
      string newPin);

    [RemoteAsync]
    IAsyncOperation<MobileBroadbandPinOperationResult> UnblockAsync(
      string pinUnblockKey,
      string newPin);
  }
}
