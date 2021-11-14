// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedMetadataTrackFailedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (TimedMetadataTrackFailedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2776615377, 26505, 19789, 176, 127, 132, 180, 243, 26, 203, 112)]
  internal interface ITimedMetadataTrackFailedEventArgs
  {
    TimedMetadataTrackError Error { get; }
  }
}
