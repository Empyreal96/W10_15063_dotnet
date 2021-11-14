// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IInteractionTrackerCustomAnimationStateEnteredArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2367458545, 55216, 17228, 165, 210, 45, 118, 17, 134, 72, 52)]
  [WebHostHidden]
  [ExclusiveTo(typeof (InteractionTrackerCustomAnimationStateEnteredArgs))]
  internal interface IInteractionTrackerCustomAnimationStateEnteredArgs
  {
    int RequestId { get; }
  }
}
