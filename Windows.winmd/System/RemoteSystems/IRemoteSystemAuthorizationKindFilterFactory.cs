// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemAuthorizationKindFilterFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [Guid(2909134669, 46698, 17828, 129, 119, 140, 174, 215, 93, 158, 90)]
  [ExclusiveTo(typeof (RemoteSystemAuthorizationKindFilter))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IRemoteSystemAuthorizationKindFilterFactory
  {
    RemoteSystemAuthorizationKindFilter Create(
      RemoteSystemAuthorizationKind remoteSystemAuthorizationKind);
  }
}
