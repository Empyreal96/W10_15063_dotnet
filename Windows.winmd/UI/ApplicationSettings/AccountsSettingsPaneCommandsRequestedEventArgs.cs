// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.AccountsSettingsPaneCommandsRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.ApplicationSettings
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.None)]
  [DualApiPartition(version = 167772162)]
  public sealed class AccountsSettingsPaneCommandsRequestedEventArgs : 
    IAccountsSettingsPaneCommandsRequestedEventArgs
  {
    public extern IVector<WebAccountProviderCommand> WebAccountProviderCommands { [MethodImpl] get; }

    public extern IVector<WebAccountCommand> WebAccountCommands { [MethodImpl] get; }

    public extern IVector<CredentialCommand> CredentialCommands { [MethodImpl] get; }

    public extern IVector<SettingsCommand> Commands { [MethodImpl] get; }

    public extern string HeaderText { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern AccountsSettingsPaneEventDeferral GetDeferral();
  }
}
