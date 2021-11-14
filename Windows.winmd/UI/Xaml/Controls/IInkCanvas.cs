// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkCanvas
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Input.Inking;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(692337704, 36424, 20424, 164, 115, 53, 176, 186, 18, 172, 234)]
  [ExclusiveTo(typeof (InkCanvas))]
  [WebHostHidden]
  internal interface IInkCanvas
  {
    InkPresenter InkPresenter { get; }
  }
}
