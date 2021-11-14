// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.Core.HdmiDisplayHdr2086Metadata
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display.Core
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public struct HdmiDisplayHdr2086Metadata
  {
    public ushort RedPrimaryX;
    public ushort RedPrimaryY;
    public ushort GreenPrimaryX;
    public ushort GreenPrimaryY;
    public ushort BluePrimaryX;
    public ushort BluePrimaryY;
    public ushort WhitePointX;
    public ushort WhitePointY;
    public ushort MaxMasteringLuminance;
    public ushort MinMasteringLuminance;
    public ushort MaxContentLightLevel;
    public ushort MaxFrameAverageLightLevel;
  }
}
