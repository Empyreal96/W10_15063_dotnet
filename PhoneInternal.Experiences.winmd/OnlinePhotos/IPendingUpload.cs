// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.OnlinePhotos.IPendingUpload
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.OnlinePhotos
{
  [Version(100859904)]
  [Guid(1100835833, 38767, 13517, 146, 45, 136, 43, 184, 66, 32, 224)]
  [ExclusiveTo(typeof (PendingUpload))]
  internal interface IPendingUpload
  {
    string LocalMediaId { get; }

    DateTime SubmissionTime { get; }

    PendingUploadStatus Status { get; }

    UploadStatusDetails StatusDetail { get; }

    int ErrorCode { get; }

    IAsyncAction AttemptCancelAsync();

    IAsyncAction RetryAsync();
  }
}
