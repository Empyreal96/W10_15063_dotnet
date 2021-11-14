// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemDiscoveryTypeFilter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (RemoteSystemDiscoveryTypeFilter))]
  [Guid(1121518623, 61018, 17370, 172, 106, 111, 238, 37, 70, 7, 65)]
  internal interface IRemoteSystemDiscoveryTypeFilter
  {
    RemoteSystemDiscoveryType RemoteSystemDiscoveryType { get; }
  }
}
