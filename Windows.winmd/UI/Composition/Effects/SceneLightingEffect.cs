// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Effects.SceneLightingEffect
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Windows.UI.Composition.Effects
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class SceneLightingEffect : 
    ISceneLightingEffect,
    IGraphicsEffect,
    IGraphicsEffectSource
  {
    [MethodImpl]
    public extern SceneLightingEffect();

    public extern float AmbientAmount { [MethodImpl] get; [MethodImpl] set; }

    public extern float DiffuseAmount { [MethodImpl] get; [MethodImpl] set; }

    public extern IGraphicsEffectSource NormalMapSource { [MethodImpl] get; [MethodImpl] set; }

    public extern float SpecularAmount { [MethodImpl] get; [MethodImpl] set; }

    public extern float SpecularShine { [MethodImpl] get; [MethodImpl] set; }

    public extern string Name { [MethodImpl] get; [MethodImpl] set; }
  }
}
