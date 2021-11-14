// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.IImageProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  [ExclusiveTo(typeof (ImageProperties))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1379701796, 64767, 17013, 175, 238, 236, 219, 154, 180, 121, 115)]
  internal interface IImageProperties : IStorageItemExtraProperties
  {
    uint Rating { get; set; }

    IVector<string> Keywords { get; }

    DateTime DateTaken { get; set; }

    uint Width { get; }

    uint Height { get; }

    string Title { get; set; }

    IReference<double> Latitude { get; }

    IReference<double> Longitude { get; }

    string CameraManufacturer { get; set; }

    string CameraModel { get; set; }

    PhotoOrientation Orientation { get; }

    IVectorView<string> PeopleNames { get; }
  }
}
