// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedTextSourceStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  [ExclusiveTo(typeof (TimedTextSource))]
  [Guid(3060495874, 37438, 17402, 150, 51, 88, 112, 117, 129, 45, 181)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface ITimedTextSourceStatics2
  {
    [Overload("CreateFromStreamWithIndex")]
    TimedTextSource CreateFromStreamWithIndex(
      IRandomAccessStream stream,
      IRandomAccessStream indexStream);

    [Overload("CreateFromUriWithIndex")]
    TimedTextSource CreateFromUriWithIndex(Uri uri, Uri indexUri);

    [Overload("CreateFromStreamWithIndexAndLanguage")]
    TimedTextSource CreateFromStreamWithIndex(
      IRandomAccessStream stream,
      IRandomAccessStream indexStream,
      string defaultLanguage);

    [Overload("CreateFromUriWithIndexAndLanguage")]
    TimedTextSource CreateFromUriWithIndex(
      Uri uri,
      Uri indexUri,
      string defaultLanguage);
  }
}
