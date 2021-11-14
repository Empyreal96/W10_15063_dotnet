// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICertificateRequestProperties3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3867670038, 29517, 18097, 157, 76, 110, 223, 219, 252, 132, 91)]
  [ExclusiveTo(typeof (CertificateRequestProperties))]
  internal interface ICertificateRequestProperties3
  {
    string CurveName { get; set; }

    byte[] CurveParameters { get; set; }

    string ContainerNamePrefix { get; set; }

    string ContainerName { get; set; }

    bool UseExistingKey { get; set; }
  }
}
