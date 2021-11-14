// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.VideoCompositorDefinition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(typeof (IVideoCompositorDefinitionFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class VideoCompositorDefinition : IVideoCompositorDefinition
  {
    [MethodImpl]
    public extern VideoCompositorDefinition(string activatableClassId);

    [MethodImpl]
    public extern VideoCompositorDefinition(string activatableClassId, IPropertySet props);

    public extern string ActivatableClassId { [MethodImpl] get; }

    public extern IPropertySet Properties { [MethodImpl] get; }
  }
}
