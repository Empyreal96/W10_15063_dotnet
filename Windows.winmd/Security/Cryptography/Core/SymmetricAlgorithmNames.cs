// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.SymmetricAlgorithmNames
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [Static(typeof (ISymmetricAlgorithmNamesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  public static class SymmetricAlgorithmNames
  {
    public static extern string DesCbc { [MethodImpl] get; }

    public static extern string DesEcb { [MethodImpl] get; }

    public static extern string TripleDesCbc { [MethodImpl] get; }

    public static extern string TripleDesEcb { [MethodImpl] get; }

    public static extern string Rc2Cbc { [MethodImpl] get; }

    public static extern string Rc2Ecb { [MethodImpl] get; }

    public static extern string AesCbc { [MethodImpl] get; }

    public static extern string AesEcb { [MethodImpl] get; }

    public static extern string AesGcm { [MethodImpl] get; }

    public static extern string AesCcm { [MethodImpl] get; }

    public static extern string AesCbcPkcs7 { [MethodImpl] get; }

    public static extern string AesEcbPkcs7 { [MethodImpl] get; }

    public static extern string DesCbcPkcs7 { [MethodImpl] get; }

    public static extern string DesEcbPkcs7 { [MethodImpl] get; }

    public static extern string TripleDesCbcPkcs7 { [MethodImpl] get; }

    public static extern string TripleDesEcbPkcs7 { [MethodImpl] get; }

    public static extern string Rc2CbcPkcs7 { [MethodImpl] get; }

    public static extern string Rc2EcbPkcs7 { [MethodImpl] get; }

    public static extern string Rc4 { [MethodImpl] get; }
  }
}
