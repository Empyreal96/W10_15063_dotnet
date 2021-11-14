// Decompiled with JetBrains decompiler
// Type: Windows.UI.ApplicationSettings.WebAccountCommandInvokedHandler
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ApplicationSettings
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(518448217, 5893, 19098, 181, 153, 160, 195, 214, 146, 25, 115)]
  public delegate void WebAccountCommandInvokedHandler(
    WebAccountCommand command,
    WebAccountInvokedArgs args);
}
