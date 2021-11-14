// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpCookie
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [DualApiPartition(version = 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(typeof (IHttpCookieFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  public sealed class HttpCookie : IHttpCookie, IStringable
  {
    [MethodImpl]
    public extern HttpCookie(string name, string domain, string path);

    public extern string Name { [MethodImpl] get; }

    public extern string Domain { [MethodImpl] get; }

    public extern string Path { [MethodImpl] get; }

    public extern IReference<DateTime> Expires { [MethodImpl] get; [MethodImpl] set; }

    public extern bool HttpOnly { [MethodImpl] get; [MethodImpl] set; }

    public extern bool Secure { [MethodImpl] get; [MethodImpl] set; }

    public extern string Value { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public new extern string ToString();
  }
}
