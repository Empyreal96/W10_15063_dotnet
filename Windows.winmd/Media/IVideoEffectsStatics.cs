// Decompiled with JetBrains decompiler
// Type: Windows.Media.IVideoEffectsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [Guid(533571048, 47857, 17697, 152, 12, 59, 206, 187, 68, 207, 56)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (VideoEffects))]
  internal interface IVideoEffectsStatics
  {
    string VideoStabilization { get; }
  }
}
