// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.IUriRuntimeClass
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (Uri))]
  [Guid(2654363223, 18610, 16736, 149, 111, 199, 56, 81, 32, 187, 252)]
  internal interface IUriRuntimeClass
  {
    string AbsoluteUri { get; }

    string DisplayUri { get; }

    string Domain { get; }

    string Extension { get; }

    string Fragment { get; }

    string Host { get; }

    string Password { get; }

    string Path { get; }

    string Query { get; }

    WwwFormUrlDecoder QueryParsed { get; }

    string RawUri { get; }

    string SchemeName { get; }

    string UserName { get; }

    int Port { get; }

    bool Suspicious { get; }

    bool Equals(Uri pUri);

    Uri CombineUri(string relativeUri);
  }
}
