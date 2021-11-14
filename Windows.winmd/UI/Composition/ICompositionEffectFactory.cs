// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.ICompositionEffectFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  [Guid(3193316527, 47742, 17680, 152, 80, 65, 192, 180, 255, 116, 223)]
  [ExclusiveTo(typeof (CompositionEffectFactory))]
  internal interface ICompositionEffectFactory
  {
    CompositionEffectBrush CreateBrush();

    HResult ExtendedError { get; }

    CompositionEffectFactoryLoadStatus LoadStatus { get; }
  }
}
