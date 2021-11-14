// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionEffectSourceParameter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Graphics.Effects;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CompositionEffectSourceParameter))]
  [Guid(2240459066, 12946, 20046, 179, 187, 43, 108, 101, 68, 166, 238)]
  internal interface ICompositionEffectSourceParameter : IGraphicsEffectSource
  {
    string Name { get; }
  }
}
