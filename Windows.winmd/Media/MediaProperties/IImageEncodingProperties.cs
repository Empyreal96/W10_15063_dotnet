// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.IImageEncodingProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ExclusiveTo(typeof (ImageEncodingProperties))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2019710517, 62257, 16777, 177, 195, 180, 141, 90, 224, 52, 241)]
  internal interface IImageEncodingProperties : IMediaEncodingProperties
  {
    uint Width { set; get; }

    uint Height { set; get; }
  }
}
