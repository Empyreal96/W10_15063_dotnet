// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.ISpatialAnchorManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (SpatialAnchorManager))]
  [Guid(2296581803, 62391, 16907, 176, 134, 138, 128, 192, 125, 145, 13)]
  internal interface ISpatialAnchorManagerStatics
  {
    [RemoteAsync]
    IAsyncOperation<SpatialAnchorStore> RequestStoreAsync();
  }
}
