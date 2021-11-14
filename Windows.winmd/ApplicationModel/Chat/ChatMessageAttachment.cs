// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatMessageAttachment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Chat
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IChatMessageAttachmentFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class ChatMessageAttachment : IChatMessageAttachment, IChatMessageAttachment2
  {
    [MethodImpl]
    public extern ChatMessageAttachment(
      string mimeType,
      IRandomAccessStreamReference dataStreamReference);

    public extern IRandomAccessStreamReference DataStreamReference { [MethodImpl] get; [MethodImpl] set; }

    public extern uint GroupId { [MethodImpl] get; [MethodImpl] set; }

    public extern string MimeType { [MethodImpl] get; [MethodImpl] set; }

    public extern string Text { [MethodImpl] get; [MethodImpl] set; }

    public extern IRandomAccessStreamReference Thumbnail { [MethodImpl] get; [MethodImpl] set; }

    public extern double TransferProgress { [MethodImpl] get; [MethodImpl] set; }

    public extern string OriginalFileName { [MethodImpl] get; [MethodImpl] set; }
  }
}
