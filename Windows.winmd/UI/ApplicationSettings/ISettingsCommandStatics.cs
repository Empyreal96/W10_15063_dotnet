// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.ISettingsCommandStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ApplicationSettings
{
  [ExclusiveTo(typeof (SettingsCommand))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1956309332, 12137, 19223, 138, 186, 208, 92, 229, 119, 142, 70)]
  internal interface ISettingsCommandStatics
  {
    SettingsCommand AccountsCommand { get; }
  }
}
