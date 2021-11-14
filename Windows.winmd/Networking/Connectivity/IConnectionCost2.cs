// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IConnectionCost2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2383493637, 57865, 17737, 187, 37, 94, 13, 182, 145, 203, 5)]
  [ExclusiveTo(typeof (ConnectionCost))]
  internal interface IConnectionCost2
  {
    bool BackgroundDataUsageRestricted { get; }
  }
}
