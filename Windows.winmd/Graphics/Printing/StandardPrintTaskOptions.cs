// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing.StandardPrintTaskOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IStandardPrintTaskOptionsStatic2), 196608, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IStandardPrintTaskOptionsStatic), 65536, "Windows.Foundation.UniversalApiContract")]
  [Muse(Version = 100859904)]
  public static class StandardPrintTaskOptions
  {
    public static extern string Bordering { [MethodImpl] get; }

    public static extern string MediaSize { [MethodImpl] get; }

    public static extern string MediaType { [MethodImpl] get; }

    public static extern string Orientation { [MethodImpl] get; }

    public static extern string PrintQuality { [MethodImpl] get; }

    public static extern string ColorMode { [MethodImpl] get; }

    public static extern string Duplex { [MethodImpl] get; }

    public static extern string Collation { [MethodImpl] get; }

    public static extern string Staple { [MethodImpl] get; }

    public static extern string HolePunch { [MethodImpl] get; }

    public static extern string Binding { [MethodImpl] get; }

    public static extern string Copies { [MethodImpl] get; }

    public static extern string NUp { [MethodImpl] get; }

    public static extern string InputBin { [MethodImpl] get; }
  }
}
