// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpExpectationHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Static(typeof (IHttpExpectationHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IHttpExpectationHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class HttpExpectationHeaderValue : IHttpExpectationHeaderValue, IStringable
  {
    [MethodImpl]
    public extern HttpExpectationHeaderValue(string name);

    [MethodImpl]
    public extern HttpExpectationHeaderValue(string name, string value);

    public extern string Name { [MethodImpl] get; }

    public extern string Value { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<HttpNameValueHeaderValue> Parameters { [MethodImpl] get; }

    [MethodImpl]
    public new extern string ToString();

    [MethodImpl]
    public static extern HttpExpectationHeaderValue Parse(string input);

    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpExpectationHeaderValue expectationHeaderValue);
  }
}
