// Decompiled with JetBrains decompiler
// Type: Windows.UI.Notifications.ToastNotificationManagerForUser
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Notifications
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ToastNotificationManagerForUser : 
    IToastNotificationManagerForUser,
    IToastNotificationManagerForUser2
  {
    [Overload("CreateToastNotifier")]
    [MethodImpl]
    public extern ToastNotifier CreateToastNotifier();

    [Overload("CreateToastNotifierWithId")]
    [MethodImpl]
    public extern ToastNotifier CreateToastNotifier(string applicationId);

    public extern ToastNotificationHistory History { [MethodImpl] get; }

    public extern User User { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ToastNotifier> GetToastNotifierForToastCollectionIdAsync(
      string collectionId);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<ToastNotificationHistory> GetHistoryForToastCollectionIdAsync(
      string collectionId);

    [Overload("GetToastCollectionManager")]
    [MethodImpl]
    public extern ToastCollectionManager GetToastCollectionManager();

    [Overload("GetToastCollectionManagerWithAppId")]
    [MethodImpl]
    public extern ToastCollectionManager GetToastCollectionManager(
      string appId);
  }
}
