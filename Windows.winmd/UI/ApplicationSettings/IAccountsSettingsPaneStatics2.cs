// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.IAccountsSettingsPaneStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ApplicationSettings
{
  [Guid(3525179330, 52749, 18511, 184, 232, 232, 35, 194, 21, 118, 94)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (AccountsSettingsPane))]
  internal interface IAccountsSettingsPaneStatics2 : IAccountsSettingsPaneStatics
  {
    [RemoteAsync]
    IAsyncAction ShowManageAccountsAsync();

    [RemoteAsync]
    IAsyncAction ShowAddAccountAsync();
  }
}
