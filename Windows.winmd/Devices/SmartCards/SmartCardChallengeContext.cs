// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardChallengeContext
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
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SmartCardChallengeContext : ISmartCardChallengeContext, IClosable
  {
    public extern IBuffer Challenge { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> VerifyResponseAsync(IBuffer response);

    [RemoteAsync]
    [Overload("ProvisionAsync")]
    [MethodImpl]
    public extern IAsyncAction ProvisionAsync(IBuffer response, bool formatCard);

    [Overload("ProvisionAsyncWithNewCardId")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ProvisionAsync(
      IBuffer response,
      bool formatCard,
      Guid newCardId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ChangeAdministrativeKeyAsync(
      IBuffer response,
      IBuffer newAdministrativeKey);

    [MethodImpl]
    public extern void Close();
  }
}
