// Decompiled with JetBrains decompiler
// Type: Windows.Media.Streaming.Adaptive.IAdaptiveMediaSourceCreationResult2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Streaming.Adaptive
{
  [ExclusiveTo(typeof (AdaptiveMediaSourceCreationResult))]
  [Guid(473056191, 7236, 16459, 162, 1, 223, 69, 172, 120, 152, 232)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IAdaptiveMediaSourceCreationResult2
  {
    HResult ExtendedError { get; }
  }
}
