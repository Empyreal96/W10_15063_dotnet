// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.AccountsSettingsPane
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ApplicationSettings
{
  [Muse(Version = 100859904)]
  [MarshalingBehavior(MarshalingType.None)]
  [DualApiPartition(version = 167772162)]
  [Static(typeof (IAccountsSettingsPaneStatics2), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IAccountsSettingsPaneStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class AccountsSettingsPane : IAccountsSettingsPane
  {
    public extern event TypedEventHandler<AccountsSettingsPane, AccountsSettingsPaneCommandsRequestedEventArgs> AccountCommandsRequested;

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction ShowManageAccountsAsync();

    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncAction ShowAddAccountAsync();

    [MethodImpl]
    public static extern AccountsSettingsPane GetForCurrentView();

    [MethodImpl]
    public static extern void Show();
  }
}
