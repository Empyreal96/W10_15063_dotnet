// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.Headers.HttpProductHeaderValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http.Headers
{
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IHttpProductHeaderValueFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IHttpProductHeaderValueStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class HttpProductHeaderValue : IHttpProductHeaderValue, IStringable
  {
    [MethodImpl]
    public extern HttpProductHeaderValue(string productName);

    [MethodImpl]
    public extern HttpProductHeaderValue(string productName, string productVersion);

    public extern string Name { [MethodImpl] get; }

    public extern string Version { [MethodImpl] get; }

    [MethodImpl]
    public new extern string ToString();

    [MethodImpl]
    public static extern HttpProductHeaderValue Parse(string input);

    [MethodImpl]
    public static extern bool TryParse(string input, out HttpProductHeaderValue productHeaderValue);
  }
}
