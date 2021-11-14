// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardEmulatorApduReceivedEventArgsWithCryptograms
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (SmartCardEmulatorContract), 131072)]
  [ExclusiveTo(typeof (SmartCardEmulatorApduReceivedEventArgs))]
  [Guid(3578837703, 47039, 20009, 146, 148, 12, 74, 195, 201, 65, 189)]
  internal interface ISmartCardEmulatorApduReceivedEventArgsWithCryptograms
  {
    [RemoteAsync]
    [Overload("TryRespondWithCryptogramsAsync")]
    IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus> TryRespondWithCryptogramsAsync(
      IBuffer responseTemplate,
      IIterable<SmartCardCryptogramPlacementStep> cryptogramPlacementSteps);

    [Overload("TryRespondWithCryptogramsAndStateAsync")]
    [RemoteAsync]
    IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus> TryRespondWithCryptogramsAsync(
      IBuffer responseTemplate,
      IIterable<SmartCardCryptogramPlacementStep> cryptogramPlacementSteps,
      IReference<uint> nextState);
  }
}
