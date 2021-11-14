// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.Core.ICoreInkIndependentInputSourceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking.Core
{
  [ExclusiveTo(typeof (CoreInkIndependentInputSource))]
  [Guid(1944453403, 32960, 19963, 155, 102, 16, 186, 127, 63, 156, 132)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface ICoreInkIndependentInputSourceStatics
  {
    CoreInkIndependentInputSource Create(InkPresenter inkPresenter);
  }
}
