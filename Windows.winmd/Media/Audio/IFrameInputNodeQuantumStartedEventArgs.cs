// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IFrameInputNodeQuantumStartedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1033622680, 41734, 20230, 189, 159, 233, 239, 200, 34, 99, 4)]
  [ExclusiveTo(typeof (FrameInputNodeQuantumStartedEventArgs))]
  internal interface IFrameInputNodeQuantumStartedEventArgs
  {
    int RequiredSamples { get; }
  }
}
