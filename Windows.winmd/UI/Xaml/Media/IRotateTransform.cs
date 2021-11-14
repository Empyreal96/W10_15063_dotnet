// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IRotateTransform
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (RotateTransform))]
  [Guid(1754180025, 7758, 17814, 134, 227, 66, 139, 39, 51, 79, 175)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRotateTransform
  {
    double CenterX { get; set; }

    double CenterY { get; set; }

    double Angle { get; set; }
  }
}
