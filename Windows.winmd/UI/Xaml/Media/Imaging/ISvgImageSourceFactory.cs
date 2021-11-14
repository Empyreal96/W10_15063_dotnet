// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.ISvgImageSourceFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  [ExclusiveTo(typeof (SvgImageSource))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(3348425191, 53027, 19826, 191, 26, 223, 170, 22, 216, 234, 82)]
  internal interface ISvgImageSourceFactory
  {
    SvgImageSource CreateInstance(object outer, out object inner);

    SvgImageSource CreateInstanceWithUriSource(
      Uri uriSource,
      object outer,
      out object inner);
  }
}
