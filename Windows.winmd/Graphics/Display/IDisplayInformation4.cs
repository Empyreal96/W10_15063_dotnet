// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Display.IDisplayInformation4
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Display
{
  [ExclusiveTo(typeof (DisplayInformation))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3379744303, 4674, 18110, 181, 54, 225, 170, 254, 158, 122, 207)]
  internal interface IDisplayInformation4
  {
    uint ScreenWidthInRawPixels { get; }

    uint ScreenHeightInRawPixels { get; }
  }
}
