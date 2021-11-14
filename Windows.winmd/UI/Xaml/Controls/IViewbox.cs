// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IViewbox
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Controls
{
  [Guid(86322264, 47773, 18441, 158, 195, 250, 13, 22, 113, 11, 161)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Viewbox))]
  internal interface IViewbox
  {
    UIElement Child { get; set; }

    Stretch Stretch { get; set; }

    StretchDirection StretchDirection { get; set; }
  }
}
