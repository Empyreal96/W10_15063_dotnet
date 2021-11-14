// Decompiled with JetBrains decompiler
// Type: Windows.Media.ContentRestrictions.IRatedContentDescription
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.ContentRestrictions
{
  [ExclusiveTo(typeof (RatedContentDescription))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1766352607, 26290, 19907, 150, 177, 240, 144, 238, 222, 226, 85)]
  internal interface IRatedContentDescription
  {
    string Id { get; set; }

    string Title { get; set; }

    IRandomAccessStreamReference Image { get; set; }

    RatedContentCategory Category { get; set; }

    IVector<string> Ratings { get; set; }
  }
}
