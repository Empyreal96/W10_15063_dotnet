// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.StandardCertificateStoreNames
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [DualApiPartition(version = 167772162)]
  [Static(typeof (IStandardCertificateStoreNamesStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public static class StandardCertificateStoreNames
  {
    public static extern string Personal { [MethodImpl] get; }

    public static extern string TrustedRootCertificationAuthorities { [MethodImpl] get; }

    public static extern string IntermediateCertificationAuthorities { [MethodImpl] get; }
  }
}
