// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemSessionUpdatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(377966697, 8990, 19601, 142, 200, 179, 163, 157, 158, 85, 163)]
  [ExclusiveTo(typeof (RemoteSystemSessionUpdatedEventArgs))]
  internal interface IRemoteSystemSessionUpdatedEventArgs
  {
    RemoteSystemSessionInfo SessionInfo { get; }
  }
}
