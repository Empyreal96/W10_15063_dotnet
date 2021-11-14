// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocketControl2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Security.Cryptography.Certificates;

namespace Windows.Networking.Sockets
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3268450902, 1551, 17601, 184, 226, 31, 191, 96, 189, 98, 197)]
  [ExclusiveTo(typeof (StreamSocketControl))]
  internal interface IStreamSocketControl2
  {
    IVector<ChainValidationResult> IgnorableServerCertificateErrors { get; }
  }
}
