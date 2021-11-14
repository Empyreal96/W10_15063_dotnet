// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.IWebAccountProviderCommand
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.UI.ApplicationSettings
{
  [Guid(3600539034, 41126, 20123, 136, 220, 199, 30, 117, 122, 53, 1)]
  [ExclusiveTo(typeof (WebAccountProviderCommand))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebAccountProviderCommand
  {
    WebAccountProvider WebAccountProvider { get; }

    WebAccountProviderCommandInvokedHandler Invoked { get; }
  }
}
