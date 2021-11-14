// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpDateOrDeltaHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IHttpDateOrDeltaHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class HttpDateOrDeltaHeaderValue : IHttpDateOrDeltaHeaderValue, IStringable
  {
    public extern IReference<DateTime> Date { [MethodImpl] get; }

    public extern IReference<TimeSpan> Delta { [MethodImpl] get; }

    [MethodImpl]
    public new extern string ToString();

    [MethodImpl]
    public static extern HttpDateOrDeltaHeaderValue Parse(string input);

    [MethodImpl]
    public static extern bool TryParse(
      string input,
      out HttpDateOrDeltaHeaderValue dateOrDeltaHeaderValue);
  }
}
