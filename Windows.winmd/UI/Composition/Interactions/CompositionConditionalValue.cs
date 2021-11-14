// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.CompositionConditionalValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ICompositionConditionalValueStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class CompositionConditionalValue : CompositionObject, ICompositionConditionalValue
  {
    public extern ExpressionAnimation Condition { [MethodImpl] get; [MethodImpl] set; }

    public extern ExpressionAnimation Value { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public static extern CompositionConditionalValue Create(
      Compositor compositor);
  }
}
