// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IHighDynamicRangeOutput
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Media.Devices.Core;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (HighDynamicRangeOutput))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(257392747, 9531, 16665, 187, 64, 58, 144, 229, 19, 132, 247)]
  internal interface IHighDynamicRangeOutput
  {
    double Certainty { get; }

    IVectorView<FrameController> FrameControllers { get; }
  }
}
