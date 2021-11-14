// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.KnownRetailInfoProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IKnownRetailInfoPropertiesStatics), 65536, "Windows.System.Profile.ProfileRetailInfoContract")]
  [ContractVersion(typeof (ProfileRetailInfoContract), 65536)]
  public static class KnownRetailInfoProperties
  {
    public static extern string RetailAccessCode { [MethodImpl] get; }

    public static extern string ManufacturerName { [MethodImpl] get; }

    public static extern string ModelName { [MethodImpl] get; }

    public static extern string DisplayModelName { [MethodImpl] get; }

    public static extern string Price { [MethodImpl] get; }

    public static extern string IsFeatured { [MethodImpl] get; }

    public static extern string FormFactor { [MethodImpl] get; }

    public static extern string ScreenSize { [MethodImpl] get; }

    public static extern string Weight { [MethodImpl] get; }

    public static extern string DisplayDescription { [MethodImpl] get; }

    public static extern string BatteryLifeDescription { [MethodImpl] get; }

    public static extern string ProcessorDescription { [MethodImpl] get; }

    public static extern string Memory { [MethodImpl] get; }

    public static extern string StorageDescription { [MethodImpl] get; }

    public static extern string GraphicsDescription { [MethodImpl] get; }

    public static extern string FrontCameraDescription { [MethodImpl] get; }

    public static extern string RearCameraDescription { [MethodImpl] get; }

    public static extern string HasNfc { [MethodImpl] get; }

    public static extern string HasSdSlot { [MethodImpl] get; }

    public static extern string HasOpticalDrive { [MethodImpl] get; }

    public static extern string IsOfficeInstalled { [MethodImpl] get; }

    public static extern string WindowsEdition { [MethodImpl] get; }
  }
}
