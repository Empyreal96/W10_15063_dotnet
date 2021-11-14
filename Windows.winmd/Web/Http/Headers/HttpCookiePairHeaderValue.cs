// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpCookiePairHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Static(typeof (IHttpCookiePairHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IHttpCookiePairHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class HttpCookiePairHeaderValue : IHttpCookiePairHeaderValue, IStringable
  {
    [MethodImpl]
    public extern HttpCookiePairHeaderValue(string name);

    [MethodImpl]
    public extern HttpCookiePairHeaderValue(string name, string value);

    public extern string Name { [MethodImpl] get; }

    public extern string Value { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public new extern string ToString();

    [MethodImpl]
    public static extern HttpCookiePairHeaderValue Parse(string input);

    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpCookiePairHeaderValue cookiePairHeaderValue);
  }
}
