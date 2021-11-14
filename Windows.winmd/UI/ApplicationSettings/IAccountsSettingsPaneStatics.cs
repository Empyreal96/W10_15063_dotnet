// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.IAccountsSettingsPaneStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ApplicationSettings
{
  [ExclusiveTo(typeof (AccountsSettingsPane))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1444907872, 45292, 16720, 168, 220, 32, 142, 228, 75, 6, 138)]
  internal interface IAccountsSettingsPaneStatics
  {
    AccountsSettingsPane GetForCurrentView();

    void Show();
  }
}
