// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IScaleTransform
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (ScaleTransform))]
  [WebHostHidden]
  [Guid(3983012237, 37742, 17323, 146, 154, 233, 205, 10, 81, 30, 82)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IScaleTransform
  {
    double CenterX { get; set; }

    double CenterY { get; set; }

    double ScaleX { get; set; }

    double ScaleY { get; set; }
  }
}
