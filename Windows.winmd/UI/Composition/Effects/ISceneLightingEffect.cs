// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Effects.ISceneLightingEffect
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Windows.UI.Composition.Effects
{
  [ExclusiveTo(typeof (SceneLightingEffect))]
  [Guid(2444975698, 38353, 20363, 154, 90, 100, 8, 178, 75, 140, 106)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  internal interface ISceneLightingEffect
  {
    float AmbientAmount { get; set; }

    float DiffuseAmount { get; set; }

    IGraphicsEffectSource NormalMapSource { get; set; }

    float SpecularAmount { get; set; }

    float SpecularShine { get; set; }
  }
}
