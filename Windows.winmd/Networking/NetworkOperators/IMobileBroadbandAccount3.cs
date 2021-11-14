// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IMobileBroadbandAccount3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (MobileBroadbandAccount))]
  [Guid(153755169, 37753, 19355, 173, 49, 213, 254, 226, 247, 72, 198)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IMobileBroadbandAccount3
  {
    Uri AccountExperienceUrl { get; }
  }
}
