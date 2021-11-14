// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemConnectionRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ExclusiveTo(typeof (RemoteSystemConnectionRequest))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2230141188, 36190, 19826, 130, 56, 118, 33, 87, 108, 122, 103)]
  internal interface IRemoteSystemConnectionRequest
  {
    RemoteSystem RemoteSystem { get; }
  }
}
