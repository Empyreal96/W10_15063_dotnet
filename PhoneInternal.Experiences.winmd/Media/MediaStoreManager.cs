// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.MediaStoreManager
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [Threading(ThreadingModel.Both)]
  [Static(typeof (IMediaStoreManagerStatics), 100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Version(100859904)]
  public static class MediaStoreManager
  {
    [MethodImpl]
    public static extern IAsyncOperation<MediaStore> GetAppStoreAsync(
      Guid appId);

    [MethodImpl]
    public static extern IAsyncOperation<MediaStore> GetDeviceStoreAsync();

    [MethodImpl]
    public static extern IAsyncOperation<IVector<MediaStore>> GetStoresAsync();

    [MethodImpl]
    public static extern ulong ConvertToIntId(string itemId, out uint itemType);

    [MethodImpl]
    public static extern string ConvertToStringId(ulong itemId, out uint itemType);

    [MethodImpl]
    public static extern void SetSuppressStateForFile(bool suppress, string fileName);
  }
}
