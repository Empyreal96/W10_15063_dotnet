// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedMetadataTrackProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [Guid(998187044, 63310, 19166, 147, 197, 33, 157, 160, 91, 104, 86)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public interface ITimedMetadataTrackProvider
  {
    IVectorView<TimedMetadataTrack> TimedMetadataTracks { get; }
  }
}
