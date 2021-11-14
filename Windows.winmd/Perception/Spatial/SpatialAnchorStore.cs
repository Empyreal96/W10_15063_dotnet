// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialAnchorStore
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SpatialAnchorStore : ISpatialAnchorStore
  {
    [MethodImpl]
    public extern IMapView<string, SpatialAnchor> GetAllSavedAnchors();

    [MethodImpl]
    public extern bool TrySave(string id, SpatialAnchor anchor);

    [MethodImpl]
    public extern void Remove(string id);

    [MethodImpl]
    public extern void Clear();
  }
}
