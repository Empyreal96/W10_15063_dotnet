// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintTaskOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Graphics.Printing
{
  [Muse(Version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class PrintTaskOptions : 
    IPrintTaskOptionsCore,
    IPrintTaskOptionsCoreProperties,
    IPrintTaskOptionsCoreUIConfiguration,
    IPrintTaskOptions
  {
    [MethodImpl]
    public extern PrintPageDescription GetPageDescription(uint jobPageNumber);

    public extern PrintMediaSize MediaSize { [MethodImpl] set; [MethodImpl] get; }

    public extern PrintMediaType MediaType { [MethodImpl] set; [MethodImpl] get; }

    public extern PrintOrientation Orientation { [MethodImpl] set; [MethodImpl] get; }

    public extern PrintQuality PrintQuality { [MethodImpl] set; [MethodImpl] get; }

    public extern PrintColorMode ColorMode { [MethodImpl] set; [MethodImpl] get; }

    public extern PrintDuplex Duplex { [MethodImpl] set; [MethodImpl] get; }

    public extern PrintCollation Collation { [MethodImpl] set; [MethodImpl] get; }

    public extern PrintStaple Staple { [MethodImpl] set; [MethodImpl] get; }

    public extern PrintHolePunch HolePunch { [MethodImpl] set; [MethodImpl] get; }

    public extern PrintBinding Binding { [MethodImpl] set; [MethodImpl] get; }

    public extern uint MinCopies { [MethodImpl] get; }

    public extern uint MaxCopies { [MethodImpl] get; }

    public extern uint NumberOfCopies { [MethodImpl] set; [MethodImpl] get; }

    public extern IVector<string> DisplayedOptions { [MethodImpl] get; }

    public extern PrintBordering Bordering { [MethodImpl] set; [MethodImpl] get; }

    [MethodImpl]
    public extern IRandomAccessStream GetPagePrintTicket(
      PrintPageInfo printPageInfo);
  }
}
