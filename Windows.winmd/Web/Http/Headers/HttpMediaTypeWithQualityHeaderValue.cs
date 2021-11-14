// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpMediaTypeWithQualityHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IHttpMediaTypeWithQualityHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IHttpMediaTypeWithQualityHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HttpMediaTypeWithQualityHeaderValue : 
    IHttpMediaTypeWithQualityHeaderValue,
    IStringable
  {
    [MethodImpl]
    public extern HttpMediaTypeWithQualityHeaderValue(string mediaType);

    [MethodImpl]
    public extern HttpMediaTypeWithQualityHeaderValue(string mediaType, double quality);

    public extern string CharSet { [MethodImpl] get; [MethodImpl] set; }

    public extern string MediaType { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<HttpNameValueHeaderValue> Parameters { [MethodImpl] get; }

    public extern IReference<double> Quality { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public new extern string ToString();

    [MethodImpl]
    public static extern HttpMediaTypeWithQualityHeaderValue Parse(
      string input);

    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpMediaTypeWithQualityHeaderValue mediaTypeWithQualityHeaderValue);
  }
}
