// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.ISourceChangeRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.PlayTo
{
  [Guid(4215224982, 31398, 19083, 134, 231, 84, 246, 198, 211, 79, 100)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SourceChangeRequestedEventArgs))]
  internal interface ISourceChangeRequestedEventArgs
  {
    IRandomAccessStreamWithContentType Stream { get; }

    string Title { get; }

    string Author { get; }

    string Album { get; }

    string Genre { get; }

    string Description { get; }

    IReference<DateTime> Date { get; }

    IRandomAccessStreamReference Thumbnail { get; }

    IReference<uint> Rating { get; }

    IMapView<string, object> Properties { get; }
  }
}
