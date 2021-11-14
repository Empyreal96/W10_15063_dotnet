// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxValidateCertificatesRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (EmailMailboxValidateCertificatesRequest))]
  [Guid(2840410417, 57626, 20375, 184, 26, 24, 122, 112, 168, 244, 26)]
  internal interface IEmailMailboxValidateCertificatesRequest
  {
    string EmailMailboxId { get; }

    IVectorView<Certificate> Certificates { get; }

    [RemoteAsync]
    IAsyncAction ReportCompletedAsync(
      IIterable<EmailCertificateValidationStatus> validationStatuses);

    [RemoteAsync]
    IAsyncAction ReportFailedAsync();
  }
}
