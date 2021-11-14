// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IInteractionTrackerOwner
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [WebHostHidden]
  [Guid(3677260531, 19947, 20051, 178, 156, 176, 108, 159, 150, 214, 81)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public interface IInteractionTrackerOwner
  {
    void CustomAnimationStateEntered(
      InteractionTracker sender,
      InteractionTrackerCustomAnimationStateEnteredArgs args);

    void IdleStateEntered(InteractionTracker sender, InteractionTrackerIdleStateEnteredArgs args);

    void InertiaStateEntered(
      InteractionTracker sender,
      InteractionTrackerInertiaStateEnteredArgs args);

    void InteractingStateEntered(
      InteractionTracker sender,
      InteractionTrackerInteractingStateEnteredArgs args);

    void RequestIgnored(InteractionTracker sender, InteractionTrackerRequestIgnoredArgs args);

    void ValuesChanged(InteractionTracker sender, InteractionTrackerValuesChangedArgs args);
  }
}
