// Decompiled with JetBrains decompiler
// Type: Windows.Security.Credentials.IKeyCredentialAttestationResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Credentials
{
  [ExclusiveTo(typeof (KeyCredentialAttestationResult))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2024453025, 41921, 16643, 182, 204, 71, 44, 68, 23, 28, 187)]
  internal interface IKeyCredentialAttestationResult
  {
    IBuffer CertificateChainBuffer { get; }

    IBuffer AttestationBuffer { get; }

    KeyCredentialAttestationStatus Status { get; }
  }
}
