// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpContentRangeHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [Activatable(typeof (IHttpContentRangeHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IHttpContentRangeHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class HttpContentRangeHeaderValue : IHttpContentRangeHeaderValue, IStringable
  {
    [MethodImpl]
    public extern HttpContentRangeHeaderValue(ulong length);

    [MethodImpl]
    public extern HttpContentRangeHeaderValue(ulong from, ulong to);

    [MethodImpl]
    public extern HttpContentRangeHeaderValue(ulong from, ulong to, ulong length);

    public extern IReference<ulong> FirstBytePosition { [MethodImpl] get; }

    public extern IReference<ulong> LastBytePosition { [MethodImpl] get; }

    public extern IReference<ulong> Length { [MethodImpl] get; }

    public extern string Unit { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public new extern string ToString();

    [MethodImpl]
    public static extern HttpContentRangeHeaderValue Parse(string input);

    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpContentRangeHeaderValue contentRangeHeaderValue);
  }
}
