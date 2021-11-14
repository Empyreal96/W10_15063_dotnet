// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpNameValueHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IHttpNameValueHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IHttpNameValueHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class HttpNameValueHeaderValue : IHttpNameValueHeaderValue, IStringable
  {
    [MethodImpl]
    public extern HttpNameValueHeaderValue(string name);

    [MethodImpl]
    public extern HttpNameValueHeaderValue(string name, string value);

    public extern string Name { [MethodImpl] get; }

    public extern string Value { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public new extern string ToString();

    [MethodImpl]
    public static extern HttpNameValueHeaderValue Parse(string input);

    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpNameValueHeaderValue nameValueHeaderValue);
  }
}
