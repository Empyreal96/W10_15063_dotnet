// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.IUserCertificateStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3388677507, 30879, 19278, 145, 128, 4, 90, 117, 122, 172, 109)]
  [ExclusiveTo(typeof (UserCertificateStore))]
  internal interface IUserCertificateStore
  {
    [RemoteAsync]
    IAsyncOperation<bool> RequestAddAsync(Certificate certificate);

    [RemoteAsync]
    IAsyncOperation<bool> RequestDeleteAsync(Certificate certificate);

    string Name { get; }
  }
}
