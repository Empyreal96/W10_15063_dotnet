// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemAddedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ExclusiveTo(typeof (RemoteSystemAddedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2402899471, 58676, 18071, 136, 54, 122, 190, 161, 81, 81, 110)]
  internal interface IRemoteSystemAddedEventArgs
  {
    RemoteSystem RemoteSystem { get; }
  }
}
