// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessageChange
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(471384917, 16926, 21688, 109, 56, 107, 58, 108, 130, 252, 204)]
  [ExclusiveTo(typeof (ChatMessageChange))]
  internal interface IChatMessageChange
  {
    ChatMessageChangeType ChangeType { get; }

    ChatMessage Message { get; }
  }
}
