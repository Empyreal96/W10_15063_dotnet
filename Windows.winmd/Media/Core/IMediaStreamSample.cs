// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSample
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  [Guid(1552791079, 19328, 17249, 152, 55, 108, 183, 72, 26, 217, 214)]
  [ExclusiveTo(typeof (MediaStreamSample))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMediaStreamSample
  {
    event TypedEventHandler<MediaStreamSample, object> Processed;

    Buffer Buffer { get; }

    TimeSpan Timestamp { get; }

    MediaStreamSamplePropertySet ExtendedProperties { get; }

    MediaStreamSampleProtectionProperties Protection { get; }

    TimeSpan DecodeTimestamp { set; get; }

    TimeSpan Duration { set; get; }

    bool KeyFrame { set; get; }

    bool Discontinuous { set; get; }
  }
}
