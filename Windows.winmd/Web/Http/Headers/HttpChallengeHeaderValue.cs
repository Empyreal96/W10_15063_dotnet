// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpChallengeHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IHttpChallengeHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IHttpChallengeHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class HttpChallengeHeaderValue : IHttpChallengeHeaderValue, IStringable
  {
    [MethodImpl]
    public extern HttpChallengeHeaderValue(string scheme);

    [MethodImpl]
    public extern HttpChallengeHeaderValue(string scheme, string token);

    public extern IVector<HttpNameValueHeaderValue> Parameters { [MethodImpl] get; }

    public extern string Scheme { [MethodImpl] get; }

    public extern string Token { [MethodImpl] get; }

    [MethodImpl]
    public new extern string ToString();

    [MethodImpl]
    public static extern HttpChallengeHeaderValue Parse(string input);

    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpChallengeHeaderValue challengeHeaderValue);
  }
}
