// Decompiled with JetBrains decompiler
// Type: Windows.Perception.Spatial.SpatialEntity
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Perception.Spatial
{
  [Activatable(typeof (ISpatialEntityFactory), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class SpatialEntity : ISpatialEntity
  {
    [MethodImpl]
    public extern SpatialEntity(SpatialAnchor spatialAnchor);

    [MethodImpl]
    public extern SpatialEntity(SpatialAnchor spatialAnchor, ValueSet propertySet);

    public extern string Id { [MethodImpl] get; }

    public extern SpatialAnchor Anchor { [MethodImpl] get; }

    public extern ValueSet Properties { [MethodImpl] get; }
  }
}
