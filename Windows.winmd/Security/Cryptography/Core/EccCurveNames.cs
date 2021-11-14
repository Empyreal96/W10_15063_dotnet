// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.EccCurveNames
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [Static(typeof (IEccCurveNamesStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class EccCurveNames
  {
    public static extern string BrainpoolP160r1 { [MethodImpl] get; }

    public static extern string BrainpoolP160t1 { [MethodImpl] get; }

    public static extern string BrainpoolP192r1 { [MethodImpl] get; }

    public static extern string BrainpoolP192t1 { [MethodImpl] get; }

    public static extern string BrainpoolP224r1 { [MethodImpl] get; }

    public static extern string BrainpoolP224t1 { [MethodImpl] get; }

    public static extern string BrainpoolP256r1 { [MethodImpl] get; }

    public static extern string BrainpoolP256t1 { [MethodImpl] get; }

    public static extern string BrainpoolP320r1 { [MethodImpl] get; }

    public static extern string BrainpoolP320t1 { [MethodImpl] get; }

    public static extern string BrainpoolP384r1 { [MethodImpl] get; }

    public static extern string BrainpoolP384t1 { [MethodImpl] get; }

    public static extern string BrainpoolP512r1 { [MethodImpl] get; }

    public static extern string BrainpoolP512t1 { [MethodImpl] get; }

    public static extern string Curve25519 { [MethodImpl] get; }

    public static extern string Ec192wapi { [MethodImpl] get; }

    public static extern string NistP192 { [MethodImpl] get; }

    public static extern string NistP224 { [MethodImpl] get; }

    public static extern string NistP256 { [MethodImpl] get; }

    public static extern string NistP384 { [MethodImpl] get; }

    public static extern string NistP521 { [MethodImpl] get; }

    public static extern string NumsP256t1 { [MethodImpl] get; }

    public static extern string NumsP384t1 { [MethodImpl] get; }

    public static extern string NumsP512t1 { [MethodImpl] get; }

    public static extern string SecP160k1 { [MethodImpl] get; }

    public static extern string SecP160r1 { [MethodImpl] get; }

    public static extern string SecP160r2 { [MethodImpl] get; }

    public static extern string SecP192k1 { [MethodImpl] get; }

    public static extern string SecP192r1 { [MethodImpl] get; }

    public static extern string SecP224k1 { [MethodImpl] get; }

    public static extern string SecP224r1 { [MethodImpl] get; }

    public static extern string SecP256k1 { [MethodImpl] get; }

    public static extern string SecP256r1 { [MethodImpl] get; }

    public static extern string SecP384r1 { [MethodImpl] get; }

    public static extern string SecP521r1 { [MethodImpl] get; }

    public static extern string Wtls7 { [MethodImpl] get; }

    public static extern string Wtls9 { [MethodImpl] get; }

    public static extern string Wtls12 { [MethodImpl] get; }

    public static extern string X962P192v1 { [MethodImpl] get; }

    public static extern string X962P192v2 { [MethodImpl] get; }

    public static extern string X962P192v3 { [MethodImpl] get; }

    public static extern string X962P239v1 { [MethodImpl] get; }

    public static extern string X962P239v2 { [MethodImpl] get; }

    public static extern string X962P239v3 { [MethodImpl] get; }

    public static extern string X962P256v1 { [MethodImpl] get; }

    public static extern IVectorView<string> AllEccCurveNames { [MethodImpl] get; }
  }
}
