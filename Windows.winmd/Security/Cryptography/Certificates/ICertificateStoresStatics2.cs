// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificateStoresStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ExclusiveTo(typeof (CertificateStores))]
  [Guid(4203744121, 41172, 19340, 188, 85, 192, 163, 126, 177, 65, 237)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface ICertificateStoresStatics2
  {
    UserCertificateStore GetUserStoreByName(string storeName);
  }
}
