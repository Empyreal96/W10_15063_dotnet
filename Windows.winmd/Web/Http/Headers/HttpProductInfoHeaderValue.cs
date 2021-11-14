// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpProductInfoHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [DualApiPartition(version = 100859904)]
  [Static(typeof (IHttpProductInfoHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IHttpProductInfoHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class HttpProductInfoHeaderValue : IHttpProductInfoHeaderValue, IStringable
  {
    [MethodImpl]
    public extern HttpProductInfoHeaderValue(string productComment);

    [MethodImpl]
    public extern HttpProductInfoHeaderValue(string productName, string productVersion);

    public extern HttpProductHeaderValue Product { [MethodImpl] get; }

    public extern string Comment { [MethodImpl] get; }

    [MethodImpl]
    public new extern string ToString();

    [MethodImpl]
    public static extern HttpProductInfoHeaderValue Parse(string input);

    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpProductInfoHeaderValue productInfoHeaderValue);
  }
}
