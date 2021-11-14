// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.BackgroundExecutionManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IBackgroundExecutionManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class BackgroundExecutionManager
  {
    [Overload("RequestAccessAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<BackgroundAccessStatus> RequestAccessAsync();

    [RemoteAsync]
    [Overload("RequestAccessForApplicationAsync")]
    [MethodImpl]
    public static extern IAsyncOperation<BackgroundAccessStatus> RequestAccessAsync(
      string applicationId);

    [Overload("RemoveAccess")]
    [MethodImpl]
    public static extern void RemoveAccess();

    [Overload("RemoveAccessForApplication")]
    [MethodImpl]
    public static extern void RemoveAccess(string applicationId);

    [Overload("GetAccessStatus")]
    [MethodImpl]
    public static extern BackgroundAccessStatus GetAccessStatus();

    [Overload("GetAccessStatusForApplication")]
    [MethodImpl]
    public static extern BackgroundAccessStatus GetAccessStatus(
      string applicationId);
  }
}
