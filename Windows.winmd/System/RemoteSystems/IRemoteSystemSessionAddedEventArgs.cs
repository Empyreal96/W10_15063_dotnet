// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemSessionAddedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ExclusiveTo(typeof (RemoteSystemSessionAddedEventArgs))]
  [Guid(3582318420, 48279, 19513, 153, 180, 190, 202, 118, 224, 76, 63)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IRemoteSystemSessionAddedEventArgs
  {
    RemoteSystemSessionInfo SessionInfo { get; }
  }
}
