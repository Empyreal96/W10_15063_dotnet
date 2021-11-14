// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.RemoteSystemStatusTypeFilter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Activatable(typeof (IRemoteSystemStatusTypeFilterFactory), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class RemoteSystemStatusTypeFilter : 
    IRemoteSystemStatusTypeFilter,
    IRemoteSystemFilter
  {
    [MethodImpl]
    public extern RemoteSystemStatusTypeFilter(RemoteSystemStatusType remoteSystemStatusType);

    public extern RemoteSystemStatusType RemoteSystemStatusType { [MethodImpl] get; }
  }
}
