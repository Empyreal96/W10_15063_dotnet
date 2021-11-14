// Decompiled with JetBrains decompiler
// Type: Windows.Networking.IEndpointPairFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EndpointPair))]
  [Guid(3054098801, 25824, 17451, 170, 111, 204, 140, 143, 24, 31, 120)]
  internal interface IEndpointPairFactory
  {
    EndpointPair CreateEndpointPair(
      HostName localHostName,
      string localServiceName,
      HostName remoteHostName,
      string remoteServiceName);
  }
}
