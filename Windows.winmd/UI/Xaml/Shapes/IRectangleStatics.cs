// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.IRectangleStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Shapes
{
  [ExclusiveTo(typeof (Rectangle))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2670045779, 47930, 19516, 137, 219, 111, 188, 13, 31, 160, 204)]
  internal interface IRectangleStatics
  {
    DependencyProperty RadiusXProperty { get; }

    DependencyProperty RadiusYProperty { get; }
  }
}
