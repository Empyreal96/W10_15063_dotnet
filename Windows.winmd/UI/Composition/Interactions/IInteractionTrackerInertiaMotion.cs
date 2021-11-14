// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IInteractionTrackerInertiaMotion
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [WebHostHidden]
  [Guid(76689372, 61780, 19640, 191, 51, 204, 27, 166, 17, 230, 219)]
  [ExclusiveTo(typeof (InteractionTrackerInertiaMotion))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IInteractionTrackerInertiaMotion
  {
    ExpressionAnimation Condition { get; set; }

    ExpressionAnimation Motion { get; set; }
  }
}
