// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.IPrintSchema
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Printers
{
  [ExclusiveTo(typeof (PrintSchema))]
  [Guid(3266937622, 9912, 19451, 129, 56, 159, 150, 44, 34, 163, 91)]
  [ContractVersion(typeof (PrintersContract), 65536)]
  internal interface IPrintSchema
  {
    [RemoteAsync]
    IAsyncOperation<IRandomAccessStreamWithContentType> GetDefaultPrintTicketAsync();

    [RemoteAsync]
    IAsyncOperation<IRandomAccessStreamWithContentType> GetCapabilitiesAsync(
      IRandomAccessStreamWithContentType constrainTicket);

    [RemoteAsync]
    IAsyncOperation<IRandomAccessStreamWithContentType> MergeAndValidateWithDefaultPrintTicketAsync(
      IRandomAccessStreamWithContentType deltaTicket);
  }
}
