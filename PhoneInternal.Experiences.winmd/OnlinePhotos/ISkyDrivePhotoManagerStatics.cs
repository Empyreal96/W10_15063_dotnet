// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.OnlinePhotos.ISkyDrivePhotoManagerStatics
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.OnlinePhotos
{
  [ExclusiveTo(typeof (SkyDrivePhotoManager))]
  [Guid(961998763, 51146, 15173, 145, 247, 47, 125, 238, 86, 182, 246)]
  [Version(100859904)]
  internal interface ISkyDrivePhotoManagerStatics
  {
    IAsyncAction UploadPhotoVideoAsync(
      string localMediaId,
      bool excludeCellular,
      bool fullFidelity,
      ulong targetTranscodedFileSize);

    IAsyncAction DeletePhotoVideoAsync(IVector<string> photoRemoteIds);

    IAsyncOperation<IVector<PendingUpload>> GetPendingUploadsAsync(
      uint status);
  }
}
