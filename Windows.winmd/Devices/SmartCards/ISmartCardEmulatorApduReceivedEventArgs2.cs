// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardEmulatorApduReceivedEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.SmartCards
{
  [Guid(2348367344, 8929, 16952, 134, 16, 148, 206, 74, 150, 84, 37)]
  [ExclusiveTo(typeof (SmartCardEmulatorApduReceivedEventArgs))]
  [ContractVersion(typeof (SmartCardEmulatorContract), 131072)]
  internal interface ISmartCardEmulatorApduReceivedEventArgs2
  {
    uint State { get; }

    [Overload("TryRespondWithStateAsync")]
    [RemoteAsync]
    IAsyncOperation<bool> TryRespondAsync(
      IBuffer responseApdu,
      IReference<uint> nextState);
  }
}
