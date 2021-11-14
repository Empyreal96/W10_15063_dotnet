// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyLicenseAcquisitionServiceRequest3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(961437517, 32629, 17165, 178, 231, 127, 117, 243, 75, 45, 117)]
  [ExclusiveTo(typeof (PlayReadyLicenseAcquisitionServiceRequest))]
  internal interface IPlayReadyLicenseAcquisitionServiceRequest3 : 
    IPlayReadyLicenseAcquisitionServiceRequest2,
    IPlayReadyLicenseAcquisitionServiceRequest,
    IPlayReadyServiceRequest,
    IMediaProtectionServiceRequest
  {
    PlayReadyLicenseIterable CreateLicenseIterable(
      PlayReadyContentHeader contentHeader,
      bool fullyEvaluated);
  }
}
