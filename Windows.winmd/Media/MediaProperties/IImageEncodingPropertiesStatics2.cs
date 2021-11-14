// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IImageEncodingPropertiesStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ExclusiveTo(typeof (ImageEncodingProperties))]
  [Guid(4139932457, 14372, 18096, 149, 110, 80, 19, 41, 225, 190, 60)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IImageEncodingPropertiesStatics2
  {
    ImageEncodingProperties CreateUncompressed(MediaPixelFormat format);

    ImageEncodingProperties CreateBmp();
  }
}
