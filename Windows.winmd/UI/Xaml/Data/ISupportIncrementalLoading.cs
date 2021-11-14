// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.ISupportIncrementalLoading
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [WebHostHidden]
  [Guid(2136926610, 30356, 20076, 165, 27, 227, 75, 244, 61, 231, 67)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ISupportIncrementalLoading
  {
    [RemoteAsync]
    IAsyncOperation<LoadMoreItemsResult> LoadMoreItemsAsync(
      uint count);

    bool HasMoreItems { get; }
  }
}
