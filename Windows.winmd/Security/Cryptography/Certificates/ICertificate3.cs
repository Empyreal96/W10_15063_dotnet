// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificate3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [Guid(3193022822, 44639, 18002, 172, 231, 198, 215, 231, 114, 76, 243)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (Certificate))]
  internal interface ICertificate3
  {
    bool IsPerUser { get; }

    string StoreName { get; }

    string KeyStorageProviderName { get; }
  }
}
