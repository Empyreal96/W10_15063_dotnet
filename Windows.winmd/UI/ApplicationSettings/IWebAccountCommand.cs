// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.IWebAccountCommand
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.UI.ApplicationSettings
{
  [ExclusiveTo(typeof (WebAccountCommand))]
  [Guid(3399717784, 40186, 16966, 176, 196, 169, 19, 163, 137, 101, 65)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IWebAccountCommand
  {
    WebAccount WebAccount { get; }

    WebAccountCommandInvokedHandler Invoked { get; }

    SupportedWebAccountActions Actions { get; }
  }
}
