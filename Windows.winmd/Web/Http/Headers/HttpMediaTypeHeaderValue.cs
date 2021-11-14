// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpMediaTypeHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IHttpMediaTypeHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IHttpMediaTypeHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class HttpMediaTypeHeaderValue : IHttpMediaTypeHeaderValue, IStringable
  {
    [MethodImpl]
    public extern HttpMediaTypeHeaderValue(string mediaType);

    public extern string CharSet { [MethodImpl] get; [MethodImpl] set; }

    public extern string MediaType { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<HttpNameValueHeaderValue> Parameters { [MethodImpl] get; }

    [MethodImpl]
    public new extern string ToString();

    [MethodImpl]
    public static extern HttpMediaTypeHeaderValue Parse(string input);

    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpMediaTypeHeaderValue mediaTypeHeaderValue);
  }
}
