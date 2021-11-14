// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.KeyDerivationAlgorithmNames
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [Static(typeof (IKeyDerivationAlgorithmNamesStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IKeyDerivationAlgorithmNamesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class KeyDerivationAlgorithmNames
  {
    public static extern string CapiKdfMd5 { [MethodImpl] get; }

    public static extern string CapiKdfSha1 { [MethodImpl] get; }

    public static extern string CapiKdfSha256 { [MethodImpl] get; }

    public static extern string CapiKdfSha384 { [MethodImpl] get; }

    public static extern string CapiKdfSha512 { [MethodImpl] get; }

    public static extern string Pbkdf2Md5 { [MethodImpl] get; }

    public static extern string Pbkdf2Sha1 { [MethodImpl] get; }

    public static extern string Pbkdf2Sha256 { [MethodImpl] get; }

    public static extern string Pbkdf2Sha384 { [MethodImpl] get; }

    public static extern string Pbkdf2Sha512 { [MethodImpl] get; }

    public static extern string Sp800108CtrHmacMd5 { [MethodImpl] get; }

    public static extern string Sp800108CtrHmacSha1 { [MethodImpl] get; }

    public static extern string Sp800108CtrHmacSha256 { [MethodImpl] get; }

    public static extern string Sp800108CtrHmacSha384 { [MethodImpl] get; }

    public static extern string Sp800108CtrHmacSha512 { [MethodImpl] get; }

    public static extern string Sp80056aConcatMd5 { [MethodImpl] get; }

    public static extern string Sp80056aConcatSha1 { [MethodImpl] get; }

    public static extern string Sp80056aConcatSha256 { [MethodImpl] get; }

    public static extern string Sp80056aConcatSha384 { [MethodImpl] get; }

    public static extern string Sp80056aConcatSha512 { [MethodImpl] get; }
  }
}
