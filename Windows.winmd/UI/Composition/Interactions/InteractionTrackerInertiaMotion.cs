// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.InteractionTrackerInertiaMotion
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IInteractionTrackerInertiaMotionStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class InteractionTrackerInertiaMotion : 
    InteractionTrackerInertiaModifier,
    IInteractionTrackerInertiaMotion
  {
    public extern ExpressionAnimation Condition { [MethodImpl] get; [MethodImpl] set; }

    public extern ExpressionAnimation Motion { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public static extern InteractionTrackerInertiaMotion Create(
      Compositor compositor);
  }
}
