// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemDiscoveryTypeFilterFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [Guid(2677979539, 49760, 16737, 146, 242, 156, 2, 31, 35, 254, 93)]
  [ExclusiveTo(typeof (RemoteSystemDiscoveryTypeFilter))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IRemoteSystemDiscoveryTypeFilterFactory
  {
    RemoteSystemDiscoveryTypeFilter Create(
      RemoteSystemDiscoveryType discoveryType);
  }
}
