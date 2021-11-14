// Decompiled with JetBrains decompiler
// Type: Windows.Devices.SmartCards.ISmartCardReader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.SmartCards
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(276083936, 21698, 19952, 129, 122, 20, 193, 67, 120, 240, 108)]
  [ExclusiveTo(typeof (SmartCardReader))]
  internal interface ISmartCardReader
  {
    string DeviceId { get; }

    string Name { get; }

    SmartCardReaderKind Kind { get; }

    [RemoteAsync]
    IAsyncOperation<SmartCardReaderStatus> GetStatusAsync();

    [RemoteAsync]
    IAsyncOperation<IVectorView<SmartCard>> FindAllCardsAsync();

    event TypedEventHandler<SmartCardReader, CardAddedEventArgs> CardAdded;

    event TypedEventHandler<SmartCardReader, CardRemovedEventArgs> CardRemoved;
  }
}
