// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.StepEasingFunction
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class StepEasingFunction : CompositionEasingFunction, IStepEasingFunction
  {
    public extern int FinalStep { [MethodImpl] get; [MethodImpl] set; }

    public extern int InitialStep { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsFinalStepSingleFrame { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsInitialStepSingleFrame { [MethodImpl] get; [MethodImpl] set; }

    public extern int StepCount { [MethodImpl] get; [MethodImpl] set; }
  }
}
