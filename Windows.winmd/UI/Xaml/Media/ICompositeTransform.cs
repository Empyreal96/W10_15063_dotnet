// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ICompositeTransform
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3366205531, 62026, 18177, 162, 101, 167, 136, 70, 241, 66, 185)]
  [ExclusiveTo(typeof (CompositeTransform))]
  internal interface ICompositeTransform
  {
    double CenterX { get; set; }

    double CenterY { get; set; }

    double ScaleX { get; set; }

    double ScaleY { get; set; }

    double SkewX { get; set; }

    double SkewY { get; set; }

    double Rotation { get; set; }

    double TranslateX { get; set; }

    double TranslateY { get; set; }
  }
}
