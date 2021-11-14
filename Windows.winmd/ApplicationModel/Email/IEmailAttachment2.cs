// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.IEmailAttachment2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Email
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(576655472, 45311, 17777, 157, 84, 167, 6, 196, 141, 85, 198)]
  [ExclusiveTo(typeof (EmailAttachment))]
  internal interface IEmailAttachment2
  {
    string Id { get; }

    string ContentId { get; set; }

    string ContentLocation { get; set; }

    EmailAttachmentDownloadState DownloadState { get; set; }

    ulong EstimatedDownloadSizeInBytes { get; set; }

    bool IsFromBaseMessage { get; }

    bool IsInline { get; set; }

    string MimeType { get; set; }
  }
}
