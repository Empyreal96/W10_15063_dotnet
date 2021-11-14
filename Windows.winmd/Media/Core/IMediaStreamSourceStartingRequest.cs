// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSourceStartingRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(714118116, 13764, 19227, 167, 145, 13, 153, 219, 86, 221, 29)]
  [ExclusiveTo(typeof (MediaStreamSourceStartingRequest))]
  internal interface IMediaStreamSourceStartingRequest
  {
    IReference<TimeSpan> StartPosition { get; }

    MediaStreamSourceStartingRequestDeferral GetDeferral();

    void SetActualStartPosition(TimeSpan position);
  }
}
