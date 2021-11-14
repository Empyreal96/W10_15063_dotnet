// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.IInteractionTrackerInertiaMotionStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [ExclusiveTo(typeof (InteractionTrackerInertiaMotion))]
  [Guid(2361933270, 47739, 17178, 132, 75, 110, 172, 145, 48, 249, 154)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IInteractionTrackerInertiaMotionStatics
  {
    InteractionTrackerInertiaMotion Create(Compositor compositor);
  }
}
