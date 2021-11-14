// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintTaskOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Printing
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (PrintTaskOptions))]
  [Guid(1510631099, 53897, 16827, 150, 221, 87, 226, 131, 56, 174, 63)]
  internal interface IPrintTaskOptions
  {
    PrintBordering Bordering { set; get; }

    IRandomAccessStream GetPagePrintTicket(PrintPageInfo printPageInfo);
  }
}
