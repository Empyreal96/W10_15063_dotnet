// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.IKnownRetailInfoPropertiesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  [ExclusiveTo(typeof (KnownRetailInfoProperties))]
  [ContractVersion(typeof (ProfileRetailInfoContract), 65536)]
  [Guid(2572620152, 20495, 18558, 142, 117, 41, 229, 81, 114, 135, 18)]
  internal interface IKnownRetailInfoPropertiesStatics
  {
    string RetailAccessCode { get; }

    string ManufacturerName { get; }

    string ModelName { get; }

    string DisplayModelName { get; }

    string Price { get; }

    string IsFeatured { get; }

    string FormFactor { get; }

    string ScreenSize { get; }

    string Weight { get; }

    string DisplayDescription { get; }

    string BatteryLifeDescription { get; }

    string ProcessorDescription { get; }

    string Memory { get; }

    string StorageDescription { get; }

    string GraphicsDescription { get; }

    string FrontCameraDescription { get; }

    string RearCameraDescription { get; }

    string HasNfc { get; }

    string HasSdSlot { get; }

    string HasOpticalDrive { get; }

    string IsOfficeInstalled { get; }

    string WindowsEdition { get; }
  }
}
