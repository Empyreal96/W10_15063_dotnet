// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IInteractionTrackerIdleStateEnteredArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [WebHostHidden]
  [ExclusiveTo(typeof (InteractionTrackerIdleStateEnteredArgs))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1342255018, 5392, 16706, 161, 165, 1, 155, 9, 248, 133, 123)]
  internal interface IInteractionTrackerIdleStateEnteredArgs
  {
    int RequestId { get; }
  }
}
