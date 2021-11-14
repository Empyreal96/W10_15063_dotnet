// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.OnlinePhotos.SkyDrivePhotoManager
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.OnlinePhotos
{
  [Activatable(100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ISkyDrivePhotoManagerStatics), 100859904)]
  [Threading(ThreadingModel.Both)]
  [Version(100859904)]
  public sealed class SkyDrivePhotoManager : ISkyDrivePhotoManager
  {
    [MethodImpl]
    public extern SkyDrivePhotoManager();

    [MethodImpl]
    public static extern IAsyncAction UploadPhotoVideoAsync(
      string localMediaId,
      bool excludeCellular,
      bool fullFidelity,
      ulong targetTranscodedFileSize);

    [MethodImpl]
    public static extern IAsyncAction DeletePhotoVideoAsync(
      IVector<string> photoRemoteIds);

    [MethodImpl]
    public static extern IAsyncOperation<IVector<PendingUpload>> GetPendingUploadsAsync(
      uint status);
  }
}
