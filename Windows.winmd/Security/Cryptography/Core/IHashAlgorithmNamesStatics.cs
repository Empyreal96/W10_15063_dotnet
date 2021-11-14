// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IHashAlgorithmNamesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (HashAlgorithmNames))]
  [Guid(1801323798, 56982, 20234, 141, 87, 220, 201, 218, 227, 108, 118)]
  internal interface IHashAlgorithmNamesStatics
  {
    string Md5 { get; }

    string Sha1 { get; }

    string Sha256 { get; }

    string Sha384 { get; }

    string Sha512 { get; }
  }
}
