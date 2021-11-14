// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Media3D.ITransform3DFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Media3D
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(86777722, 36211, 18637, 187, 184, 208, 4, 52, 202, 174, 93)]
  [ExclusiveTo(typeof (Transform3D))]
  [WebHostHidden]
  internal interface ITransform3DFactory
  {
    Transform3D CreateInstance(object outer, out object inner);
  }
}
