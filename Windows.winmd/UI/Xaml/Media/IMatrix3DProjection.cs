// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IMatrix3DProjection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Media3D;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (Matrix3DProjection))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1862525257, 49097, 19457, 181, 120, 80, 51, 140, 236, 151, 252)]
  internal interface IMatrix3DProjection
  {
    Matrix3D ProjectionMatrix { get; set; }
  }
}
