// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystem2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(165668076, 64395, 18952, 167, 88, 104, 118, 67, 93, 118, 158)]
  [ExclusiveTo(typeof (RemoteSystem))]
  internal interface IRemoteSystem2
  {
    bool IsAvailableBySpatialProximity { get; }

    [RemoteAsync]
    IAsyncOperation<bool> GetCapabilitySupportedAsync(string capabilityName);
  }
}
