// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Core.IEccCurveNamesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Core
{
  [Guid(3019870988, 44779, 16542, 183, 212, 155, 149, 41, 90, 174, 207)]
  [ExclusiveTo(typeof (EccCurveNames))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IEccCurveNamesStatics
  {
    string BrainpoolP160r1 { get; }

    string BrainpoolP160t1 { get; }

    string BrainpoolP192r1 { get; }

    string BrainpoolP192t1 { get; }

    string BrainpoolP224r1 { get; }

    string BrainpoolP224t1 { get; }

    string BrainpoolP256r1 { get; }

    string BrainpoolP256t1 { get; }

    string BrainpoolP320r1 { get; }

    string BrainpoolP320t1 { get; }

    string BrainpoolP384r1 { get; }

    string BrainpoolP384t1 { get; }

    string BrainpoolP512r1 { get; }

    string BrainpoolP512t1 { get; }

    string Curve25519 { get; }

    string Ec192wapi { get; }

    string NistP192 { get; }

    string NistP224 { get; }

    string NistP256 { get; }

    string NistP384 { get; }

    string NistP521 { get; }

    string NumsP256t1 { get; }

    string NumsP384t1 { get; }

    string NumsP512t1 { get; }

    string SecP160k1 { get; }

    string SecP160r1 { get; }

    string SecP160r2 { get; }

    string SecP192k1 { get; }

    string SecP192r1 { get; }

    string SecP224k1 { get; }

    string SecP224r1 { get; }

    string SecP256k1 { get; }

    string SecP256r1 { get; }

    string SecP384r1 { get; }

    string SecP521r1 { get; }

    string Wtls7 { get; }

    string Wtls9 { get; }

    string Wtls12 { get; }

    string X962P192v1 { get; }

    string X962P192v2 { get; }

    string X962P192v3 { get; }

    string X962P239v1 { get; }

    string X962P239v2 { get; }

    string X962P239v3 { get; }

    string X962P256v1 { get; }

    IVectorView<string> AllEccCurveNames { get; }
  }
}
