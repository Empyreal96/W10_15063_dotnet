// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Guid(2270285824, 52913, 16963, 184, 3, 21, 212, 90, 29, 212, 40)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IChatItem
  {
    ChatItemKind ItemKind { get; }
  }
}
