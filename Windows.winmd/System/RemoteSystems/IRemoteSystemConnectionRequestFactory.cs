// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemConnectionRequestFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2852784672, 47851, 17781, 181, 48, 129, 11, 185, 120, 99, 52)]
  [ExclusiveTo(typeof (RemoteSystemConnectionRequest))]
  internal interface IRemoteSystemConnectionRequestFactory
  {
    RemoteSystemConnectionRequest Create(RemoteSystem remoteSystem);
  }
}
