// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMailboxPolicies3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [Guid(3184828447, 18535, 16714, 129, 162, 128, 57, 25, 196, 65, 145)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (EmailMailboxPolicies))]
  internal interface IEmailMailboxPolicies3
  {
    EmailMailboxAllowedSmimeEncryptionAlgorithmNegotiation AllowedSmimeEncryptionAlgorithmNegotiation { set; }

    bool AllowSmimeSoftCertificates { set; }

    IReference<EmailMailboxSmimeEncryptionAlgorithm> RequiredSmimeEncryptionAlgorithm { set; }

    IReference<EmailMailboxSmimeSigningAlgorithm> RequiredSmimeSigningAlgorithm { set; }

    bool MustEncryptSmimeMessages { set; }

    bool MustSignSmimeMessages { set; }
  }
}
