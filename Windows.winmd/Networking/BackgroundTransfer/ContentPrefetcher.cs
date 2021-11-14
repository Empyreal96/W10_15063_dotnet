// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.ContentPrefetcher
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.BackgroundTransfer
{
  [Static(typeof (IContentPrefetcherTime), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IContentPrefetcher), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class ContentPrefetcher
  {
    public static extern IReference<DateTime> LastSuccessfulPrefetchTime { [MethodImpl] get; }

    public static extern IVector<Uri> ContentUris { [MethodImpl] get; }

    public static extern Uri IndirectContentUri { [MethodImpl] set; [MethodImpl] get; }
  }
}
