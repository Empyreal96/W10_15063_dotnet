// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Imaging.BitmapPixelFormat
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Imaging
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum BitmapPixelFormat
  {
    Unknown = 0,
    Rgba16 = 12, // 0x0000000C
    Rgba8 = 30, // 0x0000001E
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Gray16 = 57, // 0x00000039
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Gray8 = 62, // 0x0000003E
    Bgra8 = 87, // 0x00000057
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Nv12 = 103, // 0x00000067
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Yuy2 = 107, // 0x0000006B
  }
}
