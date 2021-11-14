// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailMessageBatch
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ExclusiveTo(typeof (EmailMessageBatch))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1616695439, 9689, 20251, 158, 81, 5, 20, 192, 20, 150, 83)]
  internal interface IEmailMessageBatch
  {
    IVectorView<EmailMessage> Messages { get; }

    EmailBatchStatus Status { get; }
  }
}
