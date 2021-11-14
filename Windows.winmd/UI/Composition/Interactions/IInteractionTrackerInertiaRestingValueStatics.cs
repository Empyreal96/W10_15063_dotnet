// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IInteractionTrackerInertiaRestingValueStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (InteractionTrackerInertiaRestingValue))]
  [Guid(418203289, 1861, 16534, 188, 171, 58, 78, 153, 86, 155, 207)]
  [WebHostHidden]
  internal interface IInteractionTrackerInertiaRestingValueStatics
  {
    InteractionTrackerInertiaRestingValue Create(
      Compositor compositor);
  }
}
