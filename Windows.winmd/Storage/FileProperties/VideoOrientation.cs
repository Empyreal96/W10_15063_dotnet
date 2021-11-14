// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.VideoOrientation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum VideoOrientation
  {
    Normal = 0,
    Rotate90 = 90, // 0x0000005A
    Rotate180 = 180, // 0x000000B4
    Rotate270 = 270, // 0x0000010E
  }
}
