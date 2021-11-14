// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.Media.IMediaStoreManagerStatics
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.Media
{
  [Guid(1500100120, 8820, 15768, 175, 202, 193, 136, 171, 204, 4, 147)]
  [ExclusiveTo(typeof (MediaStoreManager))]
  [Version(100859904)]
  internal interface IMediaStoreManagerStatics
  {
    IAsyncOperation<MediaStore> GetAppStoreAsync(Guid appId);

    IAsyncOperation<MediaStore> GetDeviceStoreAsync();

    IAsyncOperation<IVector<MediaStore>> GetStoresAsync();

    ulong ConvertToIntId(string itemId, out uint itemType);

    string ConvertToStringId(ulong itemId, out uint itemType);

    void SetSuppressStateForFile(bool suppress, string fileName);
  }
}
