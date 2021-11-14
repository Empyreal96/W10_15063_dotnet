// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.IStandardPrintTaskOptionsStatic
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (StandardPrintTaskOptions))]
  [Guid(3024633126, 3536, 19668, 186, 255, 147, 15, 199, 214, 165, 116)]
  internal interface IStandardPrintTaskOptionsStatic
  {
    string MediaSize { get; }

    string MediaType { get; }

    string Orientation { get; }

    string PrintQuality { get; }

    string ColorMode { get; }

    string Duplex { get; }

    string Collation { get; }

    string Staple { get; }

    string HolePunch { get; }

    string Binding { get; }

    string Copies { get; }

    string NUp { get; }

    string InputBin { get; }
  }
}
