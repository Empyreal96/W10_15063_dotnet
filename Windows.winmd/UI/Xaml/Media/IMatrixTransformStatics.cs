// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IMatrixTransformStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (MatrixTransform))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1138765383, 5560, 18264, 187, 151, 125, 82, 66, 10, 204, 91)]
  [WebHostHidden]
  internal interface IMatrixTransformStatics
  {
    DependencyProperty MatrixProperty { get; }
  }
}
