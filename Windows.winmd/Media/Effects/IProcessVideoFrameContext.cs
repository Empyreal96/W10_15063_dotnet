// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IProcessVideoFrameContext
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  [ExclusiveTo(typeof (ProcessVideoFrameContext))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(661589547, 25697, 16414, 186, 120, 15, 218, 214, 17, 78, 236)]
  internal interface IProcessVideoFrameContext
  {
    VideoFrame InputFrame { get; }

    VideoFrame OutputFrame { get; }
  }
}
