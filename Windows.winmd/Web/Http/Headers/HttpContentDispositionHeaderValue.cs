// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpContentDispositionHeaderValue
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
  [Activatable(typeof (IHttpContentDispositionHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IHttpContentDispositionHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class HttpContentDispositionHeaderValue : 
    IHttpContentDispositionHeaderValue,
    IStringable
  {
    [MethodImpl]
    public extern HttpContentDispositionHeaderValue(string dispositionType);

    public extern string DispositionType { [MethodImpl] get; [MethodImpl] set; }

    public extern string FileName { [MethodImpl] get; [MethodImpl] set; }

    public extern string FileNameStar { [MethodImpl] get; [MethodImpl] set; }

    public extern string Name { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<HttpNameValueHeaderValue> Parameters { [MethodImpl] get; }

    public extern IReference<ulong> Size { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public new extern string ToString();

    [MethodImpl]
    public static extern HttpContentDispositionHeaderValue Parse(
      string input);

    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpContentDispositionHeaderValue contentDispositionHeaderValue);
  }
}
