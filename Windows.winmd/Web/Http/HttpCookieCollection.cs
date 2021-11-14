// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpCookieCollection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  public sealed class HttpCookieCollection : IVectorView<HttpCookie>, IIterable<HttpCookie>
  {
    [MethodImpl]
    public extern HttpCookie GetAt(uint index);

    public extern uint Size { [MethodImpl] get; }

    [MethodImpl]
    public extern bool IndexOf(HttpCookie value, out uint index);

    [MethodImpl]
    public extern uint GetMany(uint startIndex, [Out] HttpCookie[] items);

    [MethodImpl]
    public extern IIterator<HttpCookie> First();
  }
}
