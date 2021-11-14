// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IProcessAudioFrameContext
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  [Guid(1289300294, 4642, 18983, 165, 134, 251, 62, 32, 39, 50, 85)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ProcessAudioFrameContext))]
  internal interface IProcessAudioFrameContext
  {
    AudioFrame InputFrame { get; }

    AudioFrame OutputFrame { get; }
  }
}
