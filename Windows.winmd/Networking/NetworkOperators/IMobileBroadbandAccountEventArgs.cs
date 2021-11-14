// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandAccountEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (MobileBroadbandAccountEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(945014912, 30686, 19460, 190, 173, 161, 35, 176, 140, 159, 89)]
  internal interface IMobileBroadbandAccountEventArgs
  {
    string NetworkAccountId { get; }
  }
}
