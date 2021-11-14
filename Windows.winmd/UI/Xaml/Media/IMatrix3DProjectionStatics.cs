// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IMatrix3DProjectionStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (Matrix3DProjection))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2929547413, 16876, 20023, 171, 170, 105, 244, 29, 47, 135, 107)]
  [WebHostHidden]
  internal interface IMatrix3DProjectionStatics
  {
    DependencyProperty ProjectionMatrixProperty { get; }
  }
}
