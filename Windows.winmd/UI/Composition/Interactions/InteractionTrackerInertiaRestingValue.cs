// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.InteractionTrackerInertiaRestingValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IInteractionTrackerInertiaRestingValueStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  public sealed class InteractionTrackerInertiaRestingValue : 
    InteractionTrackerInertiaModifier,
    IInteractionTrackerInertiaRestingValue
  {
    public extern ExpressionAnimation Condition { [MethodImpl] get; [MethodImpl] set; }

    public extern ExpressionAnimation RestingValue { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public static extern InteractionTrackerInertiaRestingValue Create(
      Compositor compositor);
  }
}
