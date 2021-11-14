// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionEffectBrush
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (CompositionEffectBrush))]
  [WebHostHidden]
  [Guid(3212802398, 33740, 17599, 164, 71, 62, 60, 7, 23, 137, 236)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface ICompositionEffectBrush
  {
    CompositionBrush GetSourceParameter(string name);

    void SetSourceParameter(string name, CompositionBrush source);
  }
}
