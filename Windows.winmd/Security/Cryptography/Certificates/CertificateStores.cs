// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.CertificateStores
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ICertificateStoresStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ICertificateStoresStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 100859904)]
  [Threading(ThreadingModel.Both)]
  public static class CertificateStores
  {
    [MethodImpl]
    public static extern UserCertificateStore GetUserStoreByName(
      string storeName);

    [RemoteAsync]
    [Overload("FindAllAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<Certificate>> FindAllAsync();

    [Overload("FindAllWithQueryAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<IVectorView<Certificate>> FindAllAsync(
      CertificateQuery query);

    public static extern CertificateStore TrustedRootCertificationAuthorities { [MethodImpl] get; }

    public static extern CertificateStore IntermediateCertificationAuthorities { [MethodImpl] get; }

    [MethodImpl]
    public static extern CertificateStore GetStoreByName(string storeName);
  }
}
