// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Haptics.IKnownSimpleHapticsControllerWaveformsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Haptics
{
  [Guid(1029144311, 19694, 4582, 181, 53, 0, 27, 220, 6, 171, 59)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (KnownSimpleHapticsControllerWaveforms))]
  internal interface IKnownSimpleHapticsControllerWaveformsStatics
  {
    ushort Click { get; }

    ushort BuzzContinuous { get; }

    ushort RumbleContinuous { get; }

    ushort Press { get; }

    ushort Release { get; }
  }
}
