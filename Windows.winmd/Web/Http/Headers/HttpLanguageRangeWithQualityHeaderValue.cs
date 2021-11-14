// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpLanguageRangeWithQualityHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Activatable(typeof (IHttpLanguageRangeWithQualityHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IHttpLanguageRangeWithQualityHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 100859904)]
  public sealed class HttpLanguageRangeWithQualityHeaderValue : 
    IHttpLanguageRangeWithQualityHeaderValue,
    IStringable
  {
    [MethodImpl]
    public extern HttpLanguageRangeWithQualityHeaderValue(string languageRange);

    [MethodImpl]
    public extern HttpLanguageRangeWithQualityHeaderValue(string languageRange, double quality);

    public extern string LanguageRange { [MethodImpl] get; }

    public extern IReference<double> Quality { [MethodImpl] get; }

    [MethodImpl]
    public new extern string ToString();

    [MethodImpl]
    public static extern HttpLanguageRangeWithQualityHeaderValue Parse(
      string input);

    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpLanguageRangeWithQualityHeaderValue languageRangeWithQualityHeaderValue);
  }
}
