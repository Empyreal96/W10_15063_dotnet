// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.IFrameFlashCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  [Guid(3146989986, 24254, 20322, 130, 35, 14, 43, 5, 191, 187, 208)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FrameFlashCapabilities))]
  internal interface IFrameFlashCapabilities
  {
    bool Supported { get; }

    bool RedEyeReductionSupported { get; }

    bool PowerSupported { get; }
  }
}
