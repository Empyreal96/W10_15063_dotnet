// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemStatusTypeFilter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ExclusiveTo(typeof (RemoteSystemStatusTypeFilter))]
  [Guid(205082958, 52150, 18295, 133, 52, 46, 12, 82, 26, 255, 162)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IRemoteSystemStatusTypeFilter
  {
    RemoteSystemStatusType RemoteSystemStatusType { get; }
  }
}
