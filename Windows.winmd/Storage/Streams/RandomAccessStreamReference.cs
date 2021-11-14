// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.RandomAccessStreamReference
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  [Static(typeof (IRandomAccessStreamReferenceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Muse(Version = 100794368)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class RandomAccessStreamReference : IRandomAccessStreamReference
  {
    [MethodImpl]
    public extern IAsyncOperation<IRandomAccessStreamWithContentType> OpenReadAsync();

    [MethodImpl]
    public static extern RandomAccessStreamReference CreateFromFile(
      IStorageFile file);

    [MethodImpl]
    public static extern RandomAccessStreamReference CreateFromUri(
      Uri uri);

    [MethodImpl]
    public static extern RandomAccessStreamReference CreateFromStream(
      IRandomAccessStream stream);
  }
}
