// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IFlashControl2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices
{
  [Guid(2099891358, 30177, 19191, 189, 125, 78, 56, 225, 192, 108, 214)]
  [ExclusiveTo(typeof (FlashControl))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFlashControl2
  {
    bool AssistantLightSupported { get; }

    bool AssistantLightEnabled { get; set; }
  }
}
