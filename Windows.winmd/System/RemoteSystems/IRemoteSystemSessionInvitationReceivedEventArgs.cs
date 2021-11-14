// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemSessionInvitationReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ExclusiveTo(typeof (RemoteSystemSessionInvitationReceivedEventArgs))]
  [Guid(1586907693, 41229, 20187, 141, 234, 84, 210, 10, 193, 149, 67)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IRemoteSystemSessionInvitationReceivedEventArgs
  {
    RemoteSystemSessionInvitation Invitation { get; }
  }
}
