// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpRequestMessage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Web.Http.Headers;

namespace Windows.Web.Http
{
  [DualApiPartition(version = 100859904)]
  [Activatable(typeof (IHttpRequestMessageFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class HttpRequestMessage : IHttpRequestMessage, IClosable, IStringable
  {
    [MethodImpl]
    public extern HttpRequestMessage(HttpMethod method, Uri uri);

    [MethodImpl]
    public extern HttpRequestMessage();

    public extern IHttpContent Content { [MethodImpl] get; [MethodImpl] set; }

    public extern HttpRequestHeaderCollection Headers { [MethodImpl] get; }

    public extern HttpMethod Method { [MethodImpl] get; [MethodImpl] set; }

    public extern IMap<string, object> Properties { [MethodImpl] get; }

    public extern Uri RequestUri { [MethodImpl] get; [MethodImpl] set; }

    public extern HttpTransportInformation TransportInformation { [MethodImpl] get; }

    [MethodImpl]
    public extern void Close();

    [MethodImpl]
    public new extern string ToString();
  }
}
