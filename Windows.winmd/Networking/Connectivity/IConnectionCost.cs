// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IConnectionCost
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3134707753, 13334, 19216, 162, 2, 186, 192, 176, 117, 189, 174)]
  [ExclusiveTo(typeof (ConnectionCost))]
  internal interface IConnectionCost
  {
    NetworkCostType NetworkCostType { get; }

    bool Roaming { get; }

    bool OverDataLimit { get; }

    bool ApproachingDataLimit { get; }
  }
}
