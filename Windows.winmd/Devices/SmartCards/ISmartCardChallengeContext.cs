// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardChallengeContext
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SmartCardChallengeContext))]
  [Guid(422204185, 51652, 18759, 129, 204, 68, 121, 74, 97, 239, 145)]
  internal interface ISmartCardChallengeContext : IClosable
  {
    IBuffer Challenge { get; }

    [RemoteAsync]
    IAsyncOperation<bool> VerifyResponseAsync(IBuffer response);

    [Overload("ProvisionAsync")]
    [RemoteAsync]
    IAsyncAction ProvisionAsync(IBuffer response, bool formatCard);

    [Overload("ProvisionAsyncWithNewCardId")]
    [RemoteAsync]
    IAsyncAction ProvisionAsync(IBuffer response, bool formatCard, Guid newCardId);

    [RemoteAsync]
    IAsyncAction ChangeAdministrativeKeyAsync(
      IBuffer response,
      IBuffer newAdministrativeKey);
  }
}
