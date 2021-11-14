// Decompiled with JetBrains decompiler
// Type: PhoneInternal.Experiences.OnlinePhotos.PendingUpload
// Assembly: PhoneInternal.Experiences, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 227B6DCC-FFA3-4ABD-A62F-4119CA1FF2C1
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.Experiences.winmd

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace PhoneInternal.Experiences.OnlinePhotos
{
  [Threading(ThreadingModel.Both)]
  [Version(100859904)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PendingUpload : IPendingUpload
  {
    public extern string LocalMediaId { [MethodImpl] get; }

    public extern DateTime SubmissionTime { [MethodImpl] get; }

    public extern PendingUploadStatus Status { [MethodImpl] get; }

    public extern UploadStatusDetails StatusDetail { [MethodImpl] get; }

    public extern int ErrorCode { [MethodImpl] get; }

    [MethodImpl]
    public extern IAsyncAction AttemptCancelAsync();

    [MethodImpl]
    public extern IAsyncAction RetryAsync();
  }
}
