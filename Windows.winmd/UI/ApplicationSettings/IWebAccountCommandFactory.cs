// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.IWebAccountCommandFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.UI.ApplicationSettings
{
  [Guid(3215379967, 12077, 17141, 129, 222, 29, 86, 186, 252, 73, 109)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WebAccountCommand))]
  internal interface IWebAccountCommandFactory
  {
    WebAccountCommand CreateWebAccountCommand(
      WebAccount webAccount,
      WebAccountCommandInvokedHandler invoked,
      SupportedWebAccountActions actions);
  }
}
