// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ToastCollectionManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Notifications
{
  [DualApiPartition(version = 167772163)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class ToastCollectionManager : IToastCollectionManager
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction SaveToastCollectionAsync(ToastCollection collection);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<IVectorView<ToastCollection>> FindAllToastCollectionsAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ToastCollection> GetToastCollectionAsync(
      string collectionId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RemoveToastCollectionAsync(string collectionId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RemoveAllToastCollectionsAsync();

    public extern User User { [MethodImpl] get; }

    public extern string AppId { [MethodImpl] get; }
  }
}
