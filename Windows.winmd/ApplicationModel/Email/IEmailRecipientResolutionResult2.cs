// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailRecipientResolutionResult2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (EmailRecipientResolutionResult))]
  [Guid(1581386678, 52827, 19422, 185, 212, 225, 109, 160, 176, 159, 202)]
  internal interface IEmailRecipientResolutionResult2
  {
    EmailRecipientResolutionStatus Status { set; }

    void SetPublicKeys(IIterable<Certificate> value);
  }
}
