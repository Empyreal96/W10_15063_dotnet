// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IInternalOnlyDoNotUse_MediaItemQueryResult
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [Version(100859904)]
  [Guid(2427031044, 46241, 18543, 169, 118, 198, 189, 48, 49, 188, 245)]
  public interface IInternalOnlyDoNotUse_MediaItemQueryResult
  {
    IVector<string> FetchProperties { get; }

    IVector<string> FetchExtraProperties { get; }

    void GetItemCount(out uint value);

    IVector<IMediaItem> GetItems();

    IVector<IMediaItem> GetItemsEx(int count);

    void MoveLast();
  }
}
