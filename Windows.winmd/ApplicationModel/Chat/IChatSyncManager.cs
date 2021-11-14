// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.IChatSyncManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.ApplicationModel.Chat
{
  [ExclusiveTo(typeof (ChatSyncManager))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2074422371, 9808, 18543, 180, 180, 107, 217, 211, 214, 60, 132)]
  internal interface IChatSyncManager
  {
    ChatSyncConfiguration Configuration { get; }

    [RemoteAsync]
    IAsyncAction AssociateAccountAsync(WebAccount webAccount);

    [RemoteAsync]
    IAsyncAction UnassociateAccountAsync();

    bool IsAccountAssociated(WebAccount webAccount);

    void StartSync();

    [RemoteAsync]
    IAsyncAction SetConfigurationAsync(ChatSyncConfiguration configuration);
  }
}
