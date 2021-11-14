// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocketControl3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Networking.Sockets
{
  [ExclusiveTo(typeof (StreamSocketControl))]
  [Guid(3312075852, 20084, 16446, 137, 76, 179, 28, 174, 92, 115, 66)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStreamSocketControl3
  {
    bool SerializeConnectionAttempts { get; set; }

    Certificate ClientCertificate { get; set; }
  }
}
