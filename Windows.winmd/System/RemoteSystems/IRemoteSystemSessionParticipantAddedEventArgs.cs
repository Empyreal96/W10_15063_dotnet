// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemSessionParticipantAddedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ExclusiveTo(typeof (RemoteSystemSessionParticipantAddedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3545913304, 51617, 19383, 182, 176, 121, 187, 145, 173, 249, 61)]
  internal interface IRemoteSystemSessionParticipantAddedEventArgs
  {
    RemoteSystemSessionParticipant Participant { get; }
  }
}
