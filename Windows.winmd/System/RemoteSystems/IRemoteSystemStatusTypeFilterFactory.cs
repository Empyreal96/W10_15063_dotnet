// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemStatusTypeFilterFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(869234938, 55076, 16677, 172, 122, 141, 40, 30, 68, 201, 73)]
  [ExclusiveTo(typeof (RemoteSystemStatusTypeFilter))]
  internal interface IRemoteSystemStatusTypeFilterFactory
  {
    RemoteSystemStatusTypeFilter Create(
      RemoteSystemStatusType remoteSystemStatusType);
  }
}
