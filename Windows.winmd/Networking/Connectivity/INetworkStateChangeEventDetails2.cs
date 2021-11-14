// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.INetworkStateChangeEventDetails2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3594764520, 12499, 20330, 173, 71, 106, 24, 115, 206, 179, 193)]
  [ExclusiveTo(typeof (NetworkStateChangeEventDetails))]
  internal interface INetworkStateChangeEventDetails2
  {
    bool HasNewTetheringOperationalState { get; }

    bool HasNewTetheringClientCount { get; }
  }
}
