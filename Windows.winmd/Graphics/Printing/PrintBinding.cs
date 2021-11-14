// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.PrintBinding
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PrintBinding
  {
    Default,
    NotAvailable,
    PrinterCustom,
    None,
    Bale,
    BindBottom,
    BindLeft,
    BindRight,
    BindTop,
    Booklet,
    EdgeStitchBottom,
    EdgeStitchLeft,
    EdgeStitchRight,
    EdgeStitchTop,
    Fold,
    JogOffset,
    Trim,
  }
}
