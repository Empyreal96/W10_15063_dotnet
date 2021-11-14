// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.IAccountsSettingsPaneCommandsRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.ApplicationSettings
{
  [ExclusiveTo(typeof (AccountsSettingsPaneCommandsRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(996720793, 56089, 17872, 154, 191, 149, 211, 119, 60, 147, 48)]
  internal interface IAccountsSettingsPaneCommandsRequestedEventArgs
  {
    IVector<WebAccountProviderCommand> WebAccountProviderCommands { get; }

    IVector<WebAccountCommand> WebAccountCommands { get; }

    IVector<CredentialCommand> CredentialCommands { get; }

    IVector<SettingsCommand> Commands { get; }

    string HeaderText { get; set; }

    AccountsSettingsPaneEventDeferral GetDeferral();
  }
}
