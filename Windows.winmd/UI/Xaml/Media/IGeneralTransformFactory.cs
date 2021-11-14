// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IGeneralTransformFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (GeneralTransform))]
  [Guid(2049296688, 10692, 20017, 182, 249, 222, 221, 82, 228, 223, 27)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IGeneralTransformFactory
  {
    GeneralTransform CreateInstance(object outer, out object inner);
  }
}
