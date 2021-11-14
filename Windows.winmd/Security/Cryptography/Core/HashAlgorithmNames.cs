// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.HashAlgorithmNames
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IHashAlgorithmNamesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class HashAlgorithmNames
  {
    public static extern string Md5 { [MethodImpl] get; }

    public static extern string Sha1 { [MethodImpl] get; }

    public static extern string Sha256 { [MethodImpl] get; }

    public static extern string Sha384 { [MethodImpl] get; }

    public static extern string Sha512 { [MethodImpl] get; }
  }
}
