// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.TimedTextSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Core
{
  [Static(typeof (ITimedTextSourceStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ITimedTextSourceStatics2), 262144, "Windows.Foundation.UniversalApiContract")]
  public sealed class TimedTextSource : ITimedTextSource
  {
    public extern event TypedEventHandler<TimedTextSource, TimedTextSourceResolveResultEventArgs> Resolved;

    [Overload("CreateFromStreamWithIndex")]
    [MethodImpl]
    public static extern TimedTextSource CreateFromStreamWithIndex(
      IRandomAccessStream stream,
      IRandomAccessStream indexStream);

    [Overload("CreateFromUriWithIndex")]
    [MethodImpl]
    public static extern TimedTextSource CreateFromUriWithIndex(
      Uri uri,
      Uri indexUri);

    [Overload("CreateFromStreamWithIndexAndLanguage")]
    [MethodImpl]
    public static extern TimedTextSource CreateFromStreamWithIndex(
      IRandomAccessStream stream,
      IRandomAccessStream indexStream,
      string defaultLanguage);

    [Overload("CreateFromUriWithIndexAndLanguage")]
    [MethodImpl]
    public static extern TimedTextSource CreateFromUriWithIndex(
      Uri uri,
      Uri indexUri,
      string defaultLanguage);

    [Overload("CreateFromStream")]
    [MethodImpl]
    public static extern TimedTextSource CreateFromStream(IRandomAccessStream stream);

    [Overload("CreateFromUri")]
    [MethodImpl]
    public static extern TimedTextSource CreateFromUri(Uri uri);

    [Overload("CreateFromStreamWithLanguage")]
    [MethodImpl]
    public static extern TimedTextSource CreateFromStream(
      IRandomAccessStream stream,
      string defaultLanguage);

    [Overload("CreateFromUriWithLanguage")]
    [MethodImpl]
    public static extern TimedTextSource CreateFromUri(
      Uri uri,
      string defaultLanguage);
  }
}
