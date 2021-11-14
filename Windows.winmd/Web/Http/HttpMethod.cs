// Decompiled with JetBrains decompiler
// Type: Windows.Web.Http.HttpMethod
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Web.Http
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IHttpMethodStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IHttpMethodFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class HttpMethod : IHttpMethod, IStringable
  {
    [MethodImpl]
    public extern HttpMethod(string method);

    public extern string Method { [MethodImpl] get; }

    [MethodImpl]
    public new extern string ToString();

    public static extern HttpMethod Delete { [MethodImpl] get; }

    public static extern HttpMethod Get { [MethodImpl] get; }

    public static extern HttpMethod Head { [MethodImpl] get; }

    public static extern HttpMethod Options { [MethodImpl] get; }

    public static extern HttpMethod Patch { [MethodImpl] get; }

    public static extern HttpMethod Post { [MethodImpl] get; }

    public static extern HttpMethod Put { [MethodImpl] get; }
  }
}
