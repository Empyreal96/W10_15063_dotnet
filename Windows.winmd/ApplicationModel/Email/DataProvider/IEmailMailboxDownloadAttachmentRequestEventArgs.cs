// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.DataProvider.IEmailMailboxDownloadAttachmentRequestEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email.DataProvider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (EmailMailboxDownloadAttachmentRequestEventArgs))]
  [Guid(3437085805, 65448, 18551, 159, 157, 254, 215, 188, 175, 65, 4)]
  internal interface IEmailMailboxDownloadAttachmentRequestEventArgs
  {
    EmailMailboxDownloadAttachmentRequest Request { get; }

    Deferral GetDeferral();
  }
}
