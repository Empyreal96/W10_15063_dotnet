// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.Printing3DBufferFormat
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ContractVersion(typeof (Printing3DContract), 65536)]
  public enum Printing3DBufferFormat
  {
    Unknown = 0,
    R32G32B32A32Float = 2,
    R32G32B32A32UInt = 3,
    R32G32B32Float = 6,
    R32G32B32UInt = 7,
    [ContractVersion("Windows.Graphics.Printing3D.Printing3DContract", 131072)] Printing3DDouble = 500, // 0x000001F4
    [ContractVersion("Windows.Graphics.Printing3D.Printing3DContract", 131072)] Printing3DUInt = 501, // 0x000001F5
  }
}
