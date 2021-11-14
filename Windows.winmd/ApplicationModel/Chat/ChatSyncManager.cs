// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Chat.ChatSyncManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.ApplicationModel.Chat
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class ChatSyncManager : IChatSyncManager
  {
    public extern ChatSyncConfiguration Configuration { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction AssociateAccountAsync(WebAccount webAccount);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction UnassociateAccountAsync();

    [MethodImpl]
    public extern bool IsAccountAssociated(WebAccount webAccount);

    [MethodImpl]
    public extern void StartSync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SetConfigurationAsync(ChatSyncConfiguration configuration);
  }
}
