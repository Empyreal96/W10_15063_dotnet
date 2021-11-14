// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardProvisioning
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [Static(typeof (ISmartCardProvisioningStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ISmartCardProvisioningStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class SmartCardProvisioning : ISmartCardProvisioning, ISmartCardProvisioning2
  {
    public extern SmartCard SmartCard { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<Guid> GetIdAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> GetNameAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SmartCardChallengeContext> GetChallengeContextAsync();

    [MethodImpl]
    public extern IAsyncOperation<bool> RequestPinChangeAsync();

    [MethodImpl]
    public extern IAsyncOperation<bool> RequestPinResetAsync(
      SmartCardPinResetHandler handler);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<string> GetAuthorityKeyContainerNameAsync();

    [Overload("RequestAttestedVirtualSmartCardCreationAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<SmartCardProvisioning> RequestAttestedVirtualSmartCardCreationAsync(
      string friendlyName,
      IBuffer administrativeKey,
      SmartCardPinPolicy pinPolicy);

    [Overload("RequestAttestedVirtualSmartCardCreationAsyncWithCardId")]
    [MethodImpl]
    public static extern IAsyncOperation<SmartCardProvisioning> RequestAttestedVirtualSmartCardCreationAsync(
      string friendlyName,
      IBuffer administrativeKey,
      SmartCardPinPolicy pinPolicy,
      Guid cardId);

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<SmartCardProvisioning> FromSmartCardAsync(
      SmartCard card);

    [Overload("RequestVirtualSmartCardCreationAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<SmartCardProvisioning> RequestVirtualSmartCardCreationAsync(
      string friendlyName,
      IBuffer administrativeKey,
      SmartCardPinPolicy pinPolicy);

    [Overload("RequestVirtualSmartCardCreationAsyncWithCardId")]
    [MethodImpl]
    public static extern IAsyncOperation<SmartCardProvisioning> RequestVirtualSmartCardCreationAsync(
      string friendlyName,
      IBuffer administrativeKey,
      SmartCardPinPolicy pinPolicy,
      Guid cardId);

    [MethodImpl]
    public static extern IAsyncOperation<bool> RequestVirtualSmartCardDeletionAsync(
      SmartCard card);
  }
}
