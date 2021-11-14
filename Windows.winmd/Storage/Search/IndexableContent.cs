// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IndexableContent
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Storage.Search
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class IndexableContent : IIndexableContent
  {
    [MethodImpl]
    public extern IndexableContent();

    public extern string Id { [MethodImpl] get; [MethodImpl] set; }

    public extern IMap<string, object> Properties { [MethodImpl] get; }

    public extern IRandomAccessStream Stream { [MethodImpl] get; [MethodImpl] set; }

    public extern string StreamContentType { [MethodImpl] get; [MethodImpl] set; }
  }
}
