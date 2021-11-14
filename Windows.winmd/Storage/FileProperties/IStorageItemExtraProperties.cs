// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.IStorageItemExtraProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  [Guid(3309527474, 21709, 17195, 189, 188, 75, 25, 196, 180, 112, 215)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IStorageItemExtraProperties
  {
    [RemoteAsync]
    IAsyncOperation<IMap<string, object>> RetrievePropertiesAsync(
      IIterable<string> propertiesToRetrieve);

    [Overload("SavePropertiesAsync")]
    IAsyncAction SavePropertiesAsync(
      [HasVariant] IIterable<IKeyValuePair<string, object>> propertiesToSave);

    [Overload("SavePropertiesAsyncOverloadDefault")]
    [RemoteAsync]
    IAsyncAction SavePropertiesAsync();
  }
}
