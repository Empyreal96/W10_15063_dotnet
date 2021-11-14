// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.IBackgroundExecutionManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3894864472, 26281, 19777, 131, 212, 180, 193, 140, 135, 184, 70)]
  [ExclusiveTo(typeof (BackgroundExecutionManager))]
  internal interface IBackgroundExecutionManagerStatics
  {
    [Overload("RequestAccessAsync")]
    [RemoteAsync]
    IAsyncOperation<BackgroundAccessStatus> RequestAccessAsync();

    [RemoteAsync]
    [Overload("RequestAccessForApplicationAsync")]
    IAsyncOperation<BackgroundAccessStatus> RequestAccessAsync(
      string applicationId);

    [Overload("RemoveAccess")]
    void RemoveAccess();

    [Overload("RemoveAccessForApplication")]
    void RemoveAccess(string applicationId);

    [Overload("GetAccessStatus")]
    BackgroundAccessStatus GetAccessStatus();

    [Overload("GetAccessStatusForApplication")]
    BackgroundAccessStatus GetAccessStatus(string applicationId);
  }
}
