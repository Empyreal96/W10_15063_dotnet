// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkPresenterRuler
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [Guid(1826258266, 57031, 19927, 135, 122, 33, 51, 241, 131, 212, 138)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (InkPresenterRuler))]
  [WebHostHidden]
  internal interface IInkPresenterRuler : IInkPresenterStencil
  {
    double Length { get; set; }

    double Width { get; set; }
  }
}
