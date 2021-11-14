// Decompiled with JetBrains decompiler
// Type: Windows.Media.IMediaTimelineControllerFailedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [Guid(2283927581, 15991, 17403, 190, 38, 79, 200, 122, 4, 72, 52)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (MediaTimelineControllerFailedEventArgs))]
  internal interface IMediaTimelineControllerFailedEventArgs
  {
    HResult ExtendedError { get; }
  }
}
