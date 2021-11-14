// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaStreamSourceClosedRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(2424045801, 6307, 18769, 136, 122, 44, 30, 235, 213, 198, 158)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MediaStreamSourceClosedRequest))]
  internal interface IMediaStreamSourceClosedRequest
  {
    MediaStreamSourceClosedReason Reason { get; }
  }
}
