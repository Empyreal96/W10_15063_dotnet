// Decompiled with JetBrains decompiler
// Type: Windows.Storage.ISystemPhotoProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ExclusiveTo(typeof (SystemPhotoProperties))]
  [Guid(1194654781, 43809, 17444, 183, 53, 244, 53, 58, 86, 200, 252)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISystemPhotoProperties
  {
    string CameraManufacturer { get; }

    string CameraModel { get; }

    string DateTaken { get; }

    string Orientation { get; }

    string PeopleNames { get; }
  }
}
