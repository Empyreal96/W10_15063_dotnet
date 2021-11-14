// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.SmartCardEmulatorApduReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (SmartCardEmulatorContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class SmartCardEmulatorApduReceivedEventArgs : 
    ISmartCardEmulatorApduReceivedEventArgs,
    ISmartCardEmulatorApduReceivedEventArgsWithCryptograms,
    ISmartCardEmulatorApduReceivedEventArgs2
  {
    public extern IBuffer CommandApdu { [MethodImpl] get; }

    public extern SmartCardEmulatorConnectionProperties ConnectionProperties { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryRespondAsync(IBuffer responseApdu);

    public extern SmartCardAutomaticResponseStatus AutomaticResponseStatus { [MethodImpl] get; }

    [Overload("TryRespondWithCryptogramsAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus> TryRespondWithCryptogramsAsync(
      IBuffer responseTemplate,
      IIterable<SmartCardCryptogramPlacementStep> cryptogramPlacementSteps);

    [Overload("TryRespondWithCryptogramsAndStateAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<SmartCardCryptogramGeneratorOperationStatus> TryRespondWithCryptogramsAsync(
      IBuffer responseTemplate,
      IIterable<SmartCardCryptogramPlacementStep> cryptogramPlacementSteps,
      IReference<uint> nextState);

    public extern uint State { [MethodImpl] get; }

    [RemoteAsync]
    [Overload("TryRespondWithStateAsync")]
    [MethodImpl]
    public extern IAsyncOperation<bool> TryRespondAsync(
      IBuffer responseApdu,
      IReference<uint> nextState);
  }
}
