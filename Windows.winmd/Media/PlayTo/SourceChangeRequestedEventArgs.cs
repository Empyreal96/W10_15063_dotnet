// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.SourceChangeRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.PlayTo
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SourceChangeRequestedEventArgs : ISourceChangeRequestedEventArgs
  {
    public extern IRandomAccessStreamWithContentType Stream { [MethodImpl] get; }

    public extern string Title { [MethodImpl] get; }

    public extern string Author { [MethodImpl] get; }

    public extern string Album { [MethodImpl] get; }

    public extern string Genre { [MethodImpl] get; }

    public extern string Description { [MethodImpl] get; }

    public extern IReference<DateTime> Date { [MethodImpl] get; }

    public extern IRandomAccessStreamReference Thumbnail { [MethodImpl] get; }

    public extern IReference<uint> Rating { [MethodImpl] get; }

    public extern IMapView<string, object> Properties { [MethodImpl] get; }
  }
}
