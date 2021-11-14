// Decompiled with JetBrains decompiler
// Type: Windows.Networking.IEndpointPair
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking
{
  [Guid(866167350, 63738, 19248, 184, 86, 118, 81, 124, 59, 208, 109)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (EndpointPair))]
  internal interface IEndpointPair
  {
    HostName LocalHostName { get; set; }

    string LocalServiceName { get; set; }

    HostName RemoteHostName { get; set; }

    string RemoteServiceName { get; set; }
  }
}
