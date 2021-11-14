// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.IWebAccountProviderCommandFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.UI.ApplicationSettings
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3580201499, 45430, 18294, 132, 105, 169, 211, 255, 11, 63, 89)]
  [ExclusiveTo(typeof (WebAccountProviderCommand))]
  internal interface IWebAccountProviderCommandFactory
  {
    WebAccountProviderCommand CreateWebAccountProviderCommand(
      WebAccountProvider webAccountProvider,
      WebAccountProviderCommandInvokedHandler invoked);
  }
}
