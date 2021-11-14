// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageAttachment2
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
  [Guid(1591317104, 32209, 19079, 168, 206, 172, 221, 135, 216, 13, 200)]
  internal interface IChatMessageAttachment2 : IChatMessageAttachment
  {
    IRandomAccessStreamReference Thumbnail { get; set; }

    double TransferProgress { get; set; }

    string OriginalFileName { get; set; }
  }
}
