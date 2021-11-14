// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IWebSocketControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Credentials;

namespace Windows.Networking.Sockets
{
  [Guid(784645571, 55717, 17754, 152, 17, 222, 36, 212, 83, 55, 233)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IWebSocketControl
  {
    uint OutboundBufferSizeInBytes { get; set; }

    PasswordCredential ServerCredential { get; set; }

    PasswordCredential ProxyCredential { get; set; }

    IVector<string> SupportedProtocols { get; }
  }
}
