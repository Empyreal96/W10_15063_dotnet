// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Spatial.SpatialPointerInteractionSourcePose
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Foundation.Numerics;

namespace Windows.UI.Input.Spatial
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class SpatialPointerInteractionSourcePose : ISpatialPointerInteractionSourcePose
  {
    public extern Vector3 Position { [MethodImpl] get; }

    public extern Vector3 ForwardDirection { [MethodImpl] get; }

    public extern Vector3 UpDirection { [MethodImpl] get; }
  }
}
