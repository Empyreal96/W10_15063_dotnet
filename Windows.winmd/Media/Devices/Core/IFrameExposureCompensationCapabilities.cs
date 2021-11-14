// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.Core.IFrameExposureCompensationCapabilities
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Devices.Core
{
  [Guid(3112740899, 32869, 16878, 176, 79, 114, 34, 101, 149, 69, 0)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FrameExposureCompensationCapabilities))]
  internal interface IFrameExposureCompensationCapabilities
  {
    bool Supported { get; }

    float Min { get; }

    float Max { get; }

    float Step { get; }
  }
}
