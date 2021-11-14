// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatConversation2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Guid(167972049, 38970, 18346, 154, 144, 238, 72, 238, 153, 123, 89)]
  [ExclusiveTo(typeof (ChatConversation))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IChatConversation2
  {
    bool CanModifyParticipants { get; set; }
  }
}
