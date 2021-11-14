// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IWebSocketControl2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Networking.Sockets
{
  [Guid(2042871299, 62154, 17950, 175, 78, 150, 101, 188, 45, 6, 32)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public interface IWebSocketControl2 : IWebSocketControl
  {
    IVector<ChainValidationResult> IgnorableServerCertificateErrors { get; }
  }
}
