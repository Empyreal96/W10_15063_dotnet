// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IPictureQueryResult
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace PhoneInternal.Experiences.Media
{
  [Version(100859904)]
  [Guid(2663347574, 44889, 15133, 141, 231, 215, 72, 211, 127, 21, 223)]
  [ExclusiveTo(typeof (PictureQueryResult))]
  internal interface IPictureQueryResult
  {
    IVector<string> FetchProperties { get; }

    IVector<string> FetchExtraProperties { get; }

    IAsyncOperation<uint> GetPictureCountAsync();

    [Overload("GetPicturesAsync")]
    IAsyncOperation<IVector<Picture>> GetPicturesAsync();

    [Overload("GetPicturesAsyncEx")]
    IAsyncOperation<IVector<Picture>> GetPicturesAsync(int count);

    IAsyncAction MoveLastAsync();

    IAsyncOperation<Buffer> GetBookmarkAsync();

    IAsyncAction MoveToBookmarkAsync(Buffer pPosition);
  }
}
