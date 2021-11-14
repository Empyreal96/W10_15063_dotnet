// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IInteractionTrackerInertiaRestingValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (InteractionTrackerInertiaRestingValue))]
  [WebHostHidden]
  [Guid(2264394761, 20630, 16752, 156, 200, 223, 47, 225, 1, 187, 147)]
  internal interface IInteractionTrackerInertiaRestingValue
  {
    ExpressionAnimation Condition { get; set; }

    ExpressionAnimation RestingValue { get; set; }
  }
}
