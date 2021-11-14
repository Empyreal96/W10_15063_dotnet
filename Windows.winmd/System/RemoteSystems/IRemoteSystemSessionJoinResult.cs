// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemSessionJoinResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3464175364, 41022, 16804, 144, 11, 30, 121, 50, 140, 18, 103)]
  [ExclusiveTo(typeof (RemoteSystemSessionJoinResult))]
  internal interface IRemoteSystemSessionJoinResult
  {
    RemoteSystemSessionJoinStatus Status { get; }

    RemoteSystemSession Session { get; }
  }
}
