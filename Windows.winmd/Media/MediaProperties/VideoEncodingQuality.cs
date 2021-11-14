// Decompiled with JetBrains decompiler
// Type: Windows.Media.MediaProperties.VideoEncodingQuality
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.MediaProperties
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum VideoEncodingQuality
  {
    Auto,
    HD1080p,
    HD720p,
    Wvga,
    Ntsc,
    Pal,
    Vga,
    Qvga,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] Uhd2160p,
    [ContractVersion("Windows.Foundation.UniversalApiContract", 262144)] Uhd4320p,
  }
}
