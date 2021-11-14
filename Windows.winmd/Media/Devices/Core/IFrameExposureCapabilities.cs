// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.IFrameExposureCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  [Guid(3183385827, 14725, 20082, 151, 194, 5, 144, 214, 19, 7, 161)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FrameExposureCapabilities))]
  internal interface IFrameExposureCapabilities
  {
    bool Supported { get; }

    TimeSpan Min { get; }

    TimeSpan Max { get; }

    TimeSpan Step { get; }
  }
}
