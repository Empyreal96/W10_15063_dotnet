// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemSessionInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ExclusiveTo(typeof (RemoteSystemSessionInfo))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(4283299400, 35594, 20122, 153, 5, 105, 228, 184, 65, 197, 136)]
  internal interface IRemoteSystemSessionInfo
  {
    string DisplayName { get; }

    string ControllerDisplayName { get; }

    [RemoteAsync]
    IAsyncOperation<RemoteSystemSessionJoinResult> JoinAsync();
  }
}
