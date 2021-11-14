// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Media3D.IPerspectiveTransform3D
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Media3D
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(2591773482, 12537, 16545, 150, 201, 197, 157, 135, 249, 90, 195)]
  [ExclusiveTo(typeof (PerspectiveTransform3D))]
  internal interface IPerspectiveTransform3D
  {
    double Depth { get; set; }

    double OffsetX { get; set; }

    double OffsetY { get; set; }
  }
}
