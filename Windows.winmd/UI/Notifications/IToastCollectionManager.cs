// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.IToastCollectionManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Notifications
{
  [ExclusiveTo(typeof (ToastCollectionManager))]
  [Guid(706224638, 6045, 18876, 183, 157, 165, 39, 146, 13, 54, 101)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IToastCollectionManager
  {
    [RemoteAsync]
    IAsyncAction SaveToastCollectionAsync(ToastCollection collection);

    [RemoteAsync]
    IAsyncOperation<IVectorView<ToastCollection>> FindAllToastCollectionsAsync();

    [RemoteAsync]
    IAsyncOperation<ToastCollection> GetToastCollectionAsync(
      string collectionId);

    [RemoteAsync]
    IAsyncAction RemoveToastCollectionAsync(string collectionId);

    [RemoteAsync]
    IAsyncAction RemoveAllToastCollectionsAsync();

    User User { get; }

    string AppId { get; }
  }
}
