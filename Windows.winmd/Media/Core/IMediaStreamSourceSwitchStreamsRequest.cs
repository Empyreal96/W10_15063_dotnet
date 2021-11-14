// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSourceSwitchStreamsRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1102610574, 14505, 20163, 155, 160, 182, 155, 133, 80, 30, 144)]
  [ExclusiveTo(typeof (MediaStreamSourceSwitchStreamsRequest))]
  internal interface IMediaStreamSourceSwitchStreamsRequest
  {
    IMediaStreamDescriptor OldStreamDescriptor { get; }

    IMediaStreamDescriptor NewStreamDescriptor { get; }

    MediaStreamSourceSwitchStreamsRequestDeferral GetDeferral();
  }
}
