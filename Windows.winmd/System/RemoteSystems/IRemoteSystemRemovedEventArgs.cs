// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemRemovedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (RemoteSystemRemovedEventArgs))]
  [Guid(2336036539, 29446, 18922, 183, 223, 103, 213, 113, 76, 176, 19)]
  internal interface IRemoteSystemRemovedEventArgs
  {
    string RemoteSystemId { get; }
  }
}
