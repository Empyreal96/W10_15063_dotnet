// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailboxPolicies
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailMailboxPolicies))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(523453893, 7227, 19911, 180, 16, 99, 115, 120, 62, 84, 93)]
  internal interface IEmailMailboxPolicies
  {
    EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation AllowedSmimeEncryptionAlgorithmNegotiation { get; }

    bool AllowSmimeSoftCertificates { get; }

    IReference<EmailMailboxSmimeEncryptionAlgorithm> RequiredSmimeEncryptionAlgorithm { get; }

    IReference<EmailMailboxSmimeSigningAlgorithm> RequiredSmimeSigningAlgorithm { get; }
  }
}
