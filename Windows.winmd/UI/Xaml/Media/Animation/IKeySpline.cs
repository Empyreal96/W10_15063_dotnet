// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IKeySpline
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [WebHostHidden]
  [ExclusiveTo(typeof (KeySpline))]
  [Guid(2007065531, 54730, 18994, 186, 11, 125, 255, 152, 142, 88, 160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IKeySpline
  {
    Point ControlPoint1 { get; set; }

    Point ControlPoint2 { get; set; }
  }
}
