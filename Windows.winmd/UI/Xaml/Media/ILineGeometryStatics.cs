// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ILineGeometryStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [WebHostHidden]
  [ExclusiveTo(typeof (LineGeometry))]
  [Guid(1468720995, 21858, 20196, 135, 3, 234, 64, 54, 216, 145, 227)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILineGeometryStatics
  {
    DependencyProperty StartPointProperty { get; }

    DependencyProperty EndPointProperty { get; }
  }
}
