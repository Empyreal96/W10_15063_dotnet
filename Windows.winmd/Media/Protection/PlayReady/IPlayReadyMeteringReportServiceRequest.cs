// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyMeteringReportServiceRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3240829724, 3789, 20241, 161, 133, 30, 36, 164, 166, 127, 183)]
  [ExclusiveTo(typeof (PlayReadyMeteringReportServiceRequest))]
  internal interface IPlayReadyMeteringReportServiceRequest : 
    IPlayReadyServiceRequest,
    IMediaProtectionServiceRequest
  {
    byte[] MeteringCertificate { get; [param: Range(0, 2147483647)] set; }
  }
}
