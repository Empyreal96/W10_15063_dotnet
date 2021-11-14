// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Email.EmailAttachment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Email
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IEmailAttachmentFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IEmailAttachmentFactory2), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  public sealed class EmailAttachment : IEmailAttachment, IEmailAttachment2
  {
    [MethodImpl]
    public extern EmailAttachment(
      string fileName,
      IRandomAccessStreamReference data,
      string mimeType);

    [MethodImpl]
    public extern EmailAttachment(string fileName, IRandomAccessStreamReference data);

    [MethodImpl]
    public extern EmailAttachment();

    public extern string FileName { [MethodImpl] get; [MethodImpl] set; }

    public extern IRandomAccessStreamReference Data { [MethodImpl] get; [MethodImpl] set; }

    public extern string Id { [MethodImpl] get; }

    public extern string ContentId { [MethodImpl] get; [MethodImpl] set; }

    public extern string ContentLocation { [MethodImpl] get; [MethodImpl] set; }

    public extern EmailAttachmentDownloadState DownloadState { [MethodImpl] get; [MethodImpl] set; }

    public extern ulong EstimatedDownloadSizeInBytes { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsFromBaseMessage { [MethodImpl] get; }

    public extern bool IsInline { [MethodImpl] get; [MethodImpl] set; }

    public extern string MimeType { [MethodImpl] get; [MethodImpl] set; }
  }
}
