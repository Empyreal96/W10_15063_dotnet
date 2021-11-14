// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpContentCodingHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IHttpContentCodingHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IHttpContentCodingHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class HttpContentCodingHeaderValue : IHttpContentCodingHeaderValue, IStringable
  {
    [MethodImpl]
    public extern HttpContentCodingHeaderValue(string contentCoding);

    public extern string ContentCoding { [MethodImpl] get; }

    [MethodImpl]
    public new extern string ToString();

    [MethodImpl]
    public static extern HttpContentCodingHeaderValue Parse(string input);

    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpContentCodingHeaderValue contentCodingHeaderValue);
  }
}
