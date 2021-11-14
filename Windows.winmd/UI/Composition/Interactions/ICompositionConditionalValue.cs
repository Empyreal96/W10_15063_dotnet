// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.Interactions.ICompositionConditionalValue
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition.Interactions
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1126499640, 60275, 17761, 167, 29, 26, 67, 234, 235, 122, 155)]
  [ExclusiveTo(typeof (CompositionConditionalValue))]
  internal interface ICompositionConditionalValue
  {
    ExpressionAnimation Condition { get; set; }

    ExpressionAnimation Value { get; set; }
  }
}
