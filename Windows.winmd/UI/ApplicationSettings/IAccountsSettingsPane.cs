// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.IAccountsSettingsPane
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ApplicationSettings
{
  [ExclusiveTo(typeof (AccountsSettingsPane))]
  [Guid(2179634220, 20233, 17414, 165, 56, 131, 141, 155, 20, 183, 230)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAccountsSettingsPane
  {
    event TypedEventHandler<AccountsSettingsPane, AccountsSettingsPaneCommandsRequestedEventArgs> AccountCommandsRequested;
  }
}
