// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IStepEasingFunction
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (StepEasingFunction))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3502942027, 22028, 18955, 165, 246, 32, 108, 168, 195, 236, 214)]
  internal interface IStepEasingFunction
  {
    int FinalStep { get; set; }

    int InitialStep { get; set; }

    bool IsFinalStepSingleFrame { get; set; }

    bool IsInitialStepSingleFrame { get; set; }

    int StepCount { get; set; }
  }
}
