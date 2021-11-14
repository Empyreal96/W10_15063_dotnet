// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IInteractionTracker2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [ExclusiveTo(typeof (InteractionTracker))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(628529726, 52845, 17548, 131, 134, 146, 98, 13, 36, 7, 86)]
  internal interface IInteractionTracker2
  {
    void ConfigureCenterPointXInertiaModifiers(
      IIterable<CompositionConditionalValue> conditionalValues);

    void ConfigureCenterPointYInertiaModifiers(
      IIterable<CompositionConditionalValue> conditionalValues);
  }
}
