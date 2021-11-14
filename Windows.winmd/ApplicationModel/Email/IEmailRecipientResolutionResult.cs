// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailRecipientResolutionResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (EmailRecipientResolutionResult))]
  [Guid(2441296122, 36237, 17779, 128, 209, 7, 23, 42, 52, 185, 141)]
  internal interface IEmailRecipientResolutionResult
  {
    EmailRecipientResolutionStatus Status { get; }

    IVectorView<Certificate> PublicKeys { get; }
  }
}
