// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpContentCodingWithQualityHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IHttpContentCodingWithQualityHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IHttpContentCodingWithQualityHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HttpContentCodingWithQualityHeaderValue : 
    IHttpContentCodingWithQualityHeaderValue,
    IStringable
  {
    [MethodImpl]
    public extern HttpContentCodingWithQualityHeaderValue(string contentCoding);

    [MethodImpl]
    public extern HttpContentCodingWithQualityHeaderValue(string contentCoding, double quality);

    public extern string ContentCoding { [MethodImpl] get; }

    public extern IReference<double> Quality { [MethodImpl] get; }

    [MethodImpl]
    public new extern string ToString();

    [MethodImpl]
    public static extern HttpContentCodingWithQualityHeaderValue Parse(
      string input);

    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpContentCodingWithQualityHeaderValue contentCodingWithQualityHeaderValue);
  }
}
