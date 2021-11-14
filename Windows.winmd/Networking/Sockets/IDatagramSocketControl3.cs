// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Sockets.IDatagramSocketControl3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Sockets
{
  [Guid(3572204118, 8045, 17816, 155, 87, 212, 42, 0, 29, 243, 73)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DatagramSocketControl))]
  internal interface IDatagramSocketControl3
  {
    bool MulticastOnly { get; set; }
  }
}
