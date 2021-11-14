// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpConnectionOptionHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IHttpConnectionOptionHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IHttpConnectionOptionHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class HttpConnectionOptionHeaderValue : IHttpConnectionOptionHeaderValue, IStringable
  {
    [MethodImpl]
    public extern HttpConnectionOptionHeaderValue(string token);

    public extern string Token { [MethodImpl] get; }

    [MethodImpl]
    public new extern string ToString();

    [MethodImpl]
    public static extern HttpConnectionOptionHeaderValue Parse(
      string input);

    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpConnectionOptionHeaderValue connectionOptionHeaderValue);
  }
}
