// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.PlayReady.IPlayReadyRevocationServiceRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection.PlayReady
{
  [Guid(1413310124, 64240, 17760, 132, 165, 14, 74, 206, 201, 57, 228)]
  [ExclusiveTo(typeof (PlayReadyRevocationServiceRequest))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPlayReadyRevocationServiceRequest : 
    IPlayReadyServiceRequest,
    IMediaProtectionServiceRequest
  {
  }
}
