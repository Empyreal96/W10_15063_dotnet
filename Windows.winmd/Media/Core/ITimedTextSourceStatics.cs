// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedTextSourceStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  [Guid(2117146707, 39610, 19140, 187, 152, 47, 177, 118, 195, 191, 221)]
  [ExclusiveTo(typeof (TimedTextSource))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ITimedTextSourceStatics
  {
    [Overload("CreateFromStream")]
    TimedTextSource CreateFromStream(IRandomAccessStream stream);

    [Overload("CreateFromUri")]
    TimedTextSource CreateFromUri(Uri uri);

    [Overload("CreateFromStreamWithLanguage")]
    TimedTextSource CreateFromStream(
      IRandomAccessStream stream,
      string defaultLanguage);

    [Overload("CreateFromUriWithLanguage")]
    TimedTextSource CreateFromUri(Uri uri, string defaultLanguage);
  }
}
