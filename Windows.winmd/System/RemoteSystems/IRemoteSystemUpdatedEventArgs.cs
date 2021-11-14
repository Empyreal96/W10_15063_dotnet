// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemUpdatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (RemoteSystemUpdatedEventArgs))]
  [Guid(1963130638, 56267, 16725, 180, 202, 179, 10, 4, 242, 118, 39)]
  internal interface IRemoteSystemUpdatedEventArgs
  {
    RemoteSystem RemoteSystem { get; }
  }
}
