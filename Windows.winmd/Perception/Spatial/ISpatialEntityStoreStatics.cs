// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialEntityStoreStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System.RemoteSystems;

namespace Windows.Perception.Spatial
{
  [ExclusiveTo(typeof (SpatialEntityStore))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1800091806, 31824, 20114, 138, 98, 77, 29, 75, 124, 205, 62)]
  internal interface ISpatialEntityStoreStatics
  {
    bool IsSupported { get; }

    [Overload("TryGetForRemoteSystemSession")]
    SpatialEntityStore TryGet(RemoteSystemSession session);
  }
}
