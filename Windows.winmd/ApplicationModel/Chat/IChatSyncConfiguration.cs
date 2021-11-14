// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatSyncConfiguration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Chat
{
  [Guid(167274930, 27124, 19199, 130, 182, 6, 153, 47, 244, 2, 210)]
  [ExclusiveTo(typeof (ChatSyncConfiguration))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IChatSyncConfiguration
  {
    bool IsSyncEnabled { get; set; }

    ChatRestoreHistorySpan RestoreHistorySpan { get; set; }
  }
}
