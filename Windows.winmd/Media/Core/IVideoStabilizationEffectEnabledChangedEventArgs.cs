// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IVideoStabilizationEffectEnabledChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(410976040, 26555, 18195, 185, 0, 65, 104, 218, 22, 69, 41)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VideoStabilizationEffectEnabledChangedEventArgs))]
  internal interface IVideoStabilizationEffectEnabledChangedEventArgs
  {
    VideoStabilizationEffectEnabledChangedReason Reason { get; }
  }
}
