// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemSessionMessageChannelFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (RemoteSystemSessionMessageChannel))]
  [Guid(694033482, 48406, 17048, 183, 206, 65, 84, 130, 176, 225, 29)]
  internal interface IRemoteSystemSessionMessageChannelFactory
  {
    [Overload("Create")]
    RemoteSystemSessionMessageChannel Create(
      RemoteSystemSession session,
      string channelName);

    [Overload("CreateWithReliability")]
    RemoteSystemSessionMessageChannel Create(
      RemoteSystemSession session,
      string channelName,
      RemoteSystemSessionMessageChannelReliability reliability);
  }
}
