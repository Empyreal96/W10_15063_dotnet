// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Printers.PrintSchema
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Devices.Printers
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (PrintersContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class PrintSchema : IPrintSchema
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStreamWithContentType> GetDefaultPrintTicketAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStreamWithContentType> GetCapabilitiesAsync(
      IRandomAccessStreamWithContentType constrainTicket);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStreamWithContentType> MergeAndValidateWithDefaultPrintTicketAsync(
      IRandomAccessStreamWithContentType deltaTicket);
  }
}
