// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatMessage3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Guid(1961570224, 15271, 17823, 142, 11, 232, 175, 15, 235, 217, 173)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ChatMessage))]
  internal interface IChatMessage3 : IChatMessage
  {
    string RemoteId { get; }
  }
}
