// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.IRectangle
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Shapes
{
  [ExclusiveTo(typeof (Rectangle))]
  [WebHostHidden]
  [Guid(2237383216, 35345, 19992, 161, 54, 75, 194, 28, 120, 39, 176)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRectangle
  {
    double RadiusX { get; set; }

    double RadiusY { get; set; }
  }
}
