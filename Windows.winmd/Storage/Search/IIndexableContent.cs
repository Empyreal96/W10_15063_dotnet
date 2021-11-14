// Decompiled with JetBrains decompiler
// Type: Windows.Storage.Search.IIndexableContent
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Storage.Search
{
  [Guid(3438387295, 54453, 18490, 176, 110, 224, 219, 30, 196, 32, 228)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IIndexableContent
  {
    string Id { get; set; }

    IMap<string, object> Properties { get; }

    IRandomAccessStream Stream { get; set; }

    string StreamContentType { get; set; }
  }
}
