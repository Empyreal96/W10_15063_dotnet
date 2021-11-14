// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IImageEncodingPropertiesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(628910300, 35737, 17310, 170, 89, 145, 58, 54, 22, 18, 151)]
  [ExclusiveTo(typeof (ImageEncodingProperties))]
  internal interface IImageEncodingPropertiesStatics
  {
    ImageEncodingProperties CreateJpeg();

    ImageEncodingProperties CreatePng();

    ImageEncodingProperties CreateJpegXR();
  }
}
