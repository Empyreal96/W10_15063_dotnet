// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IInteractionTrackerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [Guid(3148208055, 26000, 17560, 141, 108, 235, 98, 181, 20, 201, 42)]
  [ExclusiveTo(typeof (InteractionTracker))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IInteractionTrackerStatics
  {
    InteractionTracker Create(Compositor compositor);

    InteractionTracker CreateWithOwner(
      Compositor compositor,
      IInteractionTrackerOwner owner);
  }
}
