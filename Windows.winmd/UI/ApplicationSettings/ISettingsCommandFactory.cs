// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.ISettingsCommandFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Popups;

namespace Windows.UI.ApplicationSettings
{
  [Guid(1759599411, 7299, 17210, 170, 90, 206, 238, 165, 189, 71, 100)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SettingsCommand))]
  internal interface ISettingsCommandFactory
  {
    SettingsCommand CreateSettingsCommand(
      [Variant] object settingsCommandId,
      string label,
      UICommandInvokedHandler handler);
  }
}
