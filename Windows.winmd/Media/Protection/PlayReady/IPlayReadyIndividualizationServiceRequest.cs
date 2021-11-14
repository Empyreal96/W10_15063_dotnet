// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyIndividualizationServiceRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(569747563, 140, 17937, 171, 47, 170, 166, 198, 159, 14, 36)]
  [ExclusiveTo(typeof (PlayReadyIndividualizationServiceRequest))]
  internal interface IPlayReadyIndividualizationServiceRequest : 
    IPlayReadyServiceRequest,
    IMediaProtectionServiceRequest
  {
  }
}
