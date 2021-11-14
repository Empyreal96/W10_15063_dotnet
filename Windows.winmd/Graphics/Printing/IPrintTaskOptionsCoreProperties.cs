// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IPrintTaskOptionsCoreProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3250001970, 40595, 20053, 129, 75, 51, 38, 165, 158, 252, 225)]
  public interface IPrintTaskOptionsCoreProperties
  {
    PrintMediaSize MediaSize { set; get; }

    PrintMediaType MediaType { set; get; }

    PrintOrientation Orientation { set; get; }

    PrintQuality PrintQuality { set; get; }

    PrintColorMode ColorMode { set; get; }

    PrintDuplex Duplex { set; get; }

    PrintCollation Collation { set; get; }

    PrintStaple Staple { set; get; }

    PrintHolePunch HolePunch { set; get; }

    PrintBinding Binding { set; get; }

    uint MinCopies { get; }

    uint MaxCopies { get; }

    uint NumberOfCopies { set; get; }
  }
}
