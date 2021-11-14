// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpResponseMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web.Http.Headers;

namespace Windows.Web.Http
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100859904)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IHttpResponseMessageFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class HttpResponseMessage : IHttpResponseMessage, IClosable, IStringable
  {
    [MethodImpl]
    public extern HttpResponseMessage(HttpStatusCode statusCode);

    [MethodImpl]
    public extern HttpResponseMessage();

    public extern IHttpContent Content { [MethodImpl] get; [MethodImpl] set; }

    public extern HttpResponseHeaderCollection Headers { [MethodImpl] get; }

    public extern bool IsSuccessStatusCode { [MethodImpl] get; }

    public extern string ReasonPhrase { [MethodImpl] get; [MethodImpl] set; }

    public extern HttpRequestMessage RequestMessage { [MethodImpl] get; [MethodImpl] set; }

    public extern HttpResponseMessageSource Source { [MethodImpl] get; [MethodImpl] set; }

    public extern HttpStatusCode StatusCode { [MethodImpl] get; [MethodImpl] set; }

    public extern HttpVersion Version { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern HttpResponseMessage EnsureSuccessStatusCode();

    [MethodImpl]
    public extern void Close();

    [MethodImpl]
    public new extern string ToString();
  }
}
