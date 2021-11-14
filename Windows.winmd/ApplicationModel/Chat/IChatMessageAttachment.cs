// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageAttachment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ChatMessageAttachment))]
  [Guid(3351575924, 48995, 22763, 80, 140, 139, 134, 63, 241, 107, 103)]
  internal interface IChatMessageAttachment
  {
    IRandomAccessStreamReference DataStreamReference { get; set; }

    uint GroupId { get; set; }

    string MimeType { get; set; }

    string Text { get; set; }
  }
}
