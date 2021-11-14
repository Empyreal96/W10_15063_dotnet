// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.ICompositionConditionalValueStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [Guid(151800690, 33895, 19722, 144, 101, 172, 70, 184, 10, 85, 34)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (CompositionConditionalValue))]
  [WebHostHidden]
  internal interface ICompositionConditionalValueStatics
  {
    CompositionConditionalValue Create(Compositor compositor);
  }
}
