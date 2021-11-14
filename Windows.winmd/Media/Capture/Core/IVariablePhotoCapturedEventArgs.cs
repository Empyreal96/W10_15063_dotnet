// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.Core.IVariablePhotoCapturedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture.Core
{
  [ExclusiveTo(typeof (VariablePhotoCapturedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3521858652, 6995, 20042, 139, 92, 219, 120, 135, 172, 148, 155)]
  internal interface IVariablePhotoCapturedEventArgs
  {
    CapturedFrame Frame { get; }

    TimeSpan CaptureTimeOffset { get; }

    IReference<uint> UsedFrameControllerIndex { get; }

    CapturedFrameControlValues CapturedFrameControlValues { get; }
  }
}
