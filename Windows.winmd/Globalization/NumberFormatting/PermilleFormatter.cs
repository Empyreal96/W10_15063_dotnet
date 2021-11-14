// Decompiled with JetBrains decompiler
// Type: Windows.Globalization.NumberFormatting.PermilleFormatter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Globalization.NumberFormatting
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IPermilleFormatterFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class PermilleFormatter : 
    INumberFormatterOptions,
    INumberFormatter,
    INumberFormatter2,
    INumberParser,
    ISignificantDigitsOption,
    INumberRounderOption,
    ISignedZeroOption
  {
    [MethodImpl]
    public extern PermilleFormatter(IIterable<string> languages, string geographicRegion);

    [MethodImpl]
    public extern PermilleFormatter();

    public extern IVectorView<string> Languages { [MethodImpl] get; }

    public extern string GeographicRegion { [MethodImpl] get; }

    public extern int IntegerDigits { [MethodImpl] get; [MethodImpl] set; }

    public extern int FractionDigits { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsGrouped { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsDecimalPointAlwaysDisplayed { [MethodImpl] get; [MethodImpl] set; }

    public extern string NumeralSystem { [MethodImpl] get; [MethodImpl] set; }

    public extern string ResolvedLanguage { [MethodImpl] get; }

    public extern string ResolvedGeographicRegion { [MethodImpl] get; }

    [Overload("FormatInt")]
    [MethodImpl]
    public extern string Format(long value);

    [Overload("FormatUInt")]
    [MethodImpl]
    public extern string Format(ulong value);

    [DefaultOverload]
    [Overload("FormatDouble")]
    [MethodImpl]
    public extern string Format(double value);

    [MethodImpl]
    public extern string FormatInt(long value);

    [MethodImpl]
    public extern string FormatUInt(ulong value);

    [MethodImpl]
    public extern string FormatDouble(double value);

    [MethodImpl]
    public extern IReference<long> ParseInt(string text);

    [MethodImpl]
    public extern IReference<ulong> ParseUInt(string text);

    [MethodImpl]
    public extern IReference<double> ParseDouble(string text);

    public extern int SignificantDigits { [MethodImpl] get; [MethodImpl] set; }

    public extern INumberRounder NumberRounder { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsZeroSigned { [MethodImpl] get; [MethodImpl] set; }
  }
}
