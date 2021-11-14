// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ISkewTransform
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(1317681941, 31247, 17943, 158, 152, 30, 101, 189, 201, 33, 21)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (SkewTransform))]
  internal interface ISkewTransform
  {
    double CenterX { get; set; }

    double CenterY { get; set; }

    double AngleX { get; set; }

    double AngleY { get; set; }
  }
}
