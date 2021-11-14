// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemAuthorizationKindFilter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (RemoteSystemAuthorizationKindFilter))]
  [Guid(1796071054, 1232, 16628, 162, 127, 194, 172, 187, 214, 183, 52)]
  internal interface IRemoteSystemAuthorizationKindFilter
  {
    RemoteSystemAuthorizationKind RemoteSystemAuthorizationKind { get; }
  }
}
