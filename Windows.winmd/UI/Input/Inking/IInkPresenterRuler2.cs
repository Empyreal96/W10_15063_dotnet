// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkPresenterRuler2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1158876609, 48225, 17620, 164, 35, 84, 113, 42, 230, 113, 196)]
  [ExclusiveTo(typeof (InkPresenterRuler))]
  [WebHostHidden]
  internal interface IInkPresenterRuler2
  {
    bool AreTickMarksVisible { get; set; }

    bool IsCompassVisible { get; set; }
  }
}
