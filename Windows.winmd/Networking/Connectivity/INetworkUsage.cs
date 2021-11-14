// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.INetworkUsage
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [Guid(1239060430, 39301, 18727, 191, 91, 7, 43, 92, 101, 248, 217)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (NetworkUsage))]
  internal interface INetworkUsage
  {
    ulong BytesSent { get; }

    ulong BytesReceived { get; }

    TimeSpan ConnectionDuration { get; }
  }
}
