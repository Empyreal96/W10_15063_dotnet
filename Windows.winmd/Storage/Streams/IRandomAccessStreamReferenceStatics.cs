// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Streams.IRandomAccessStreamReferenceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.Streams
{
  [Guid(2238908892, 16319, 20093, 152, 111, 239, 59, 26, 7, 169, 100)]
  [ExclusiveTo(typeof (RandomAccessStreamReference))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IRandomAccessStreamReferenceStatics
  {
    RandomAccessStreamReference CreateFromFile(IStorageFile file);

    RandomAccessStreamReference CreateFromUri(Uri uri);

    RandomAccessStreamReference CreateFromStream(
      IRandomAccessStream stream);
  }
}
