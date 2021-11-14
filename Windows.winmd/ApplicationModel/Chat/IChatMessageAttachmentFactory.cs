// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageAttachmentFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(542659234, 41814, 23409, 108, 169, 102, 201, 133, 183, 208, 213)]
  [ExclusiveTo(typeof (ChatMessageAttachment))]
  internal interface IChatMessageAttachmentFactory
  {
    ChatMessageAttachment CreateChatMessageAttachment(
      string mimeType,
      IRandomAccessStreamReference dataStreamReference);
  }
}
