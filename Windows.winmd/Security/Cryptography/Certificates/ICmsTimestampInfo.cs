// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.Certificates.ICmsTimestampInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Security.Cryptography.Certificates
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(794755314, 11288, 20360, 132, 53, 197, 52, 8, 96, 118, 245)]
  [ExclusiveTo(typeof (CmsTimestampInfo))]
  internal interface ICmsTimestampInfo
  {
    Certificate SigningCertificate { get; }

    IVectorView<Certificate> Certificates { get; }

    DateTime Timestamp { get; }
  }
}
