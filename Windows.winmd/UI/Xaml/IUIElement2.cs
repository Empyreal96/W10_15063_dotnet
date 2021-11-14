// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IUIElement2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [ExclusiveTo(typeof (UIElement))]
  [Guid(1735199737, 46700, 16854, 186, 80, 88, 207, 135, 242, 1, 209)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUIElement2
  {
    ElementCompositeMode CompositeMode { get; set; }

    bool CancelDirectManipulations();
  }
}
