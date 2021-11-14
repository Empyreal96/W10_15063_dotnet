// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IStreamSocketListenerControl
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [Guid(551077238, 36234, 19898, 151, 34, 161, 108, 77, 152, 73, 128)]
  [ExclusiveTo(typeof (StreamSocketListenerControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStreamSocketListenerControl
  {
    SocketQualityOfService QualityOfService { get; set; }
  }
}
