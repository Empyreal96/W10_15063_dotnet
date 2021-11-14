// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpCredentialsHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [Static(typeof (IHttpCredentialsHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IHttpCredentialsHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class HttpCredentialsHeaderValue : IHttpCredentialsHeaderValue, IStringable
  {
    [MethodImpl]
    public extern HttpCredentialsHeaderValue(string scheme);

    [MethodImpl]
    public extern HttpCredentialsHeaderValue(string scheme, string token);

    public extern IVector<HttpNameValueHeaderValue> Parameters { [MethodImpl] get; }

    public extern string Scheme { [MethodImpl] get; }

    public extern string Token { [MethodImpl] get; }

    [MethodImpl]
    public new extern string ToString();

    [MethodImpl]
    public static extern HttpCredentialsHeaderValue Parse(string input);

    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpCredentialsHeaderValue credentialsHeaderValue);
  }
}
