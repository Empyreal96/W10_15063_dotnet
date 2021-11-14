// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemSessionJoinRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3687468995, 33465, 18454, 156, 36, 228, 14, 97, 119, 75, 216)]
  [ExclusiveTo(typeof (RemoteSystemSessionJoinRequestedEventArgs))]
  internal interface IRemoteSystemSessionJoinRequestedEventArgs
  {
    RemoteSystemSessionJoinRequest JoinRequest { get; }

    Deferral GetDeferral();
  }
}
