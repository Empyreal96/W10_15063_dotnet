// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInkToolbarCustomPenButton
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (InkToolbarCustomPenButton))]
  [Guid(1174553601, 11050, 20284, 165, 60, 26, 4, 90, 64, 142, 250)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  internal interface IInkToolbarCustomPenButton
  {
    InkToolbarCustomPen CustomPen { get; set; }

    UIElement ConfigurationContent { get; set; }
  }
}
