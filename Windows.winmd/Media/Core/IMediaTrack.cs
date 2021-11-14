// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.IMediaTrack
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(65141500, 51505, 18714, 180, 107, 193, 14, 232, 194, 86, 183)]
  public interface IMediaTrack
  {
    string Id { get; }

    string Language { get; }

    MediaTrackKind TrackKind { get; }

    string Label { set; get; }
  }
}
