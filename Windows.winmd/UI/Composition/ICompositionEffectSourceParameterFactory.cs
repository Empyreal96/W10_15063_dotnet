// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionEffectSourceParameterFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (CompositionEffectSourceParameter))]
  [Guid(3017405046, 43939, 18212, 172, 243, 208, 57, 116, 100, 219, 28)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  internal interface ICompositionEffectSourceParameterFactory
  {
    CompositionEffectSourceParameter Create(string name);
  }
}
