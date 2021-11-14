// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSourceSampleRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(1303593385, 13569, 19867, 131, 249, 143, 35, 92, 130, 37, 50)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaStreamSourceSampleRequest))]
  internal interface IMediaStreamSourceSampleRequest
  {
    IMediaStreamDescriptor StreamDescriptor { get; }

    MediaStreamSourceSampleRequestDeferral GetDeferral();

    MediaStreamSample Sample { set; get; }

    void ReportSampleProgress(uint progress);
  }
}
