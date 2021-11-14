// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Uri
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [Activatable(typeof (IUriRuntimeClassFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IUriEscapeStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class Uri : IUriRuntimeClass, IUriRuntimeClassWithAbsoluteCanonicalUri, IStringable
  {
    [MethodImpl]
    public extern Uri(string uri);

    [MethodImpl]
    public extern Uri(string baseUri, string relativeUri);

    public extern string AbsoluteUri { [MethodImpl] get; }

    public extern string DisplayUri { [MethodImpl] get; }

    public extern string Domain { [MethodImpl] get; }

    public extern string Extension { [MethodImpl] get; }

    public extern string Fragment { [MethodImpl] get; }

    public extern string Host { [MethodImpl] get; }

    public extern string Password { [MethodImpl] get; }

    public extern string Path { [MethodImpl] get; }

    public extern string Query { [MethodImpl] get; }

    public extern WwwFormUrlDecoder QueryParsed { [MethodImpl] get; }

    public extern string RawUri { [MethodImpl] get; }

    public extern string SchemeName { [MethodImpl] get; }

    public extern string UserName { [MethodImpl] get; }

    public extern int Port { [MethodImpl] get; }

    public extern bool Suspicious { [MethodImpl] get; }

    [MethodImpl]
    public extern bool Equals(Uri pUri);

    [MethodImpl]
    public extern Uri CombineUri(string relativeUri);

    public extern string AbsoluteCanonicalUri { [MethodImpl] get; }

    public extern string DisplayIri { [MethodImpl] get; }

    [MethodImpl]
    public new extern string ToString();

    [MethodImpl]
    public static extern string UnescapeComponent(string toUnescape);

    [MethodImpl]
    public static extern string EscapeComponent(string toEscape);
  }
}
