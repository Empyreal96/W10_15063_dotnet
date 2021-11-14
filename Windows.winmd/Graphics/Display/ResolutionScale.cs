// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.ResolutionScale
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum ResolutionScale
  {
    Invalid = 0,
    Scale100Percent = 100, // 0x00000064
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Scale120Percent = 120, // 0x00000078
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Scale125Percent = 125, // 0x0000007D
    Scale140Percent = 140, // 0x0000008C
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Scale150Percent = 150, // 0x00000096
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Scale160Percent = 160, // 0x000000A0
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Scale175Percent = 175, // 0x000000AF
    Scale180Percent = 180, // 0x000000B4
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Scale200Percent = 200, // 0x000000C8
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Scale225Percent = 225, // 0x000000E1
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Scale250Percent = 250, // 0x000000FA
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Scale300Percent = 300, // 0x0000012C
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Scale350Percent = 350, // 0x0000015E
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Scale400Percent = 400, // 0x00000190
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Scale450Percent = 450, // 0x000001C2
    [ContractVersion("Windows.Foundation.UniversalApiContract", 65536)] Scale500Percent = 500, // 0x000001F4
  }
}
