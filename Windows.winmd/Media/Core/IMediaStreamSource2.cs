// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSource2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (MediaStreamSource))]
  [Guid(3965046957, 11882, 20340, 173, 187, 181, 98, 209, 83, 56, 73)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IMediaStreamSource2 : IMediaStreamSource, IMediaSource
  {
    event TypedEventHandler<MediaStreamSource, MediaStreamSourceSampleRenderedEventArgs> SampleRendered;
  }
}
