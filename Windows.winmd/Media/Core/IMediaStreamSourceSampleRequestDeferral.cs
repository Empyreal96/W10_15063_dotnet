// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSourceSampleRequestDeferral
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaStreamSourceSampleRequestDeferral))]
  [Guid(2023083010, 63874, 17352, 157, 22, 198, 45, 153, 147, 25, 190)]
  internal interface IMediaStreamSourceSampleRequestDeferral
  {
    void Complete();
  }
}
