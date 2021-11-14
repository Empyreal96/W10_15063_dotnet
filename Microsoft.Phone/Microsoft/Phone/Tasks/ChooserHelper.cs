// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.ChooserHelper
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Controls;
using Microsoft.Phone.TaskModel.Interop;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading.Tasks;
using System.Windows;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Microsoft.Phone.Tasks
{
  internal class ChooserHelper
  {
    internal static string MockAppUri = "app://CD5A4CB8-50B6-4A31-8BBB-7BF106163D5A/_default";
    private static string ImagesDirectoryName = "Images";
    private const uint maxSHLaunchTaskInputSize = 65536;
    private const string platformDataFolderName = "PlatformData";
    private static string platformDataFolderPath;

    static ChooserHelper() => ChooserHelper.DeleteImages();

    internal static bool IsExternalNavigationPending { get; set; }

    internal static void LaunchSession(Uri appUri, ParameterPropertyBag ppb)
    {
      byte[] parameterData = ChooserHelper.Serialize(ppb);
      if (appUri.IsAbsoluteUri)
        ApplicationHost.Current.RootTask.LaunchSession(appUri.AbsoluteUri, parameterData);
      else
        ApplicationHost.Current.RootTask.LaunchSession(appUri.ToString(), parameterData);
      ChooserHelper.FlagExternalNavigationPendingIfNotInProgress();
    }

    internal static void LaunchChildTask(Uri appUri, ParameterPropertyBag ppb)
    {
      byte[] parameterData = ChooserHelper.Serialize(ppb);
      if (appUri.IsAbsoluteUri)
        ApplicationHost.Current.RootTask.LaunchChildTask(appUri.AbsoluteUri, parameterData);
      else
        ApplicationHost.Current.RootTask.LaunchChildTask(appUri.ToString(), parameterData);
      ChooserHelper.FlagExternalNavigationPendingIfNotInProgress();
    }

    internal static void LaunchModernChooser(
      Uri appUri,
      string chooserTargetPackageFamilyName,
      ParameterPropertyBag ppb)
    {
      byte[] parameterData = ChooserHelper.Serialize(ppb);
      if (appUri.IsAbsoluteUri)
        ApplicationHost.Current.RootTask.LaunchModernChooser(appUri.AbsoluteUri, chooserTargetPackageFamilyName, parameterData);
      else
        ApplicationHost.Current.RootTask.LaunchModernChooser(appUri.ToString(), chooserTargetPackageFamilyName, parameterData);
      ChooserHelper.FlagExternalNavigationPendingIfNotInProgress();
    }

    internal static void LaunchUriChildTask(string uri, string parameterData)
    {
      int num = (int) ChooserHelper.LaunchUriAsChildTask(uri, parameterData);
      ChooserHelper.FlagExternalNavigationPendingIfNotInProgress();
    }

    internal static void FlagExternalNavigationPendingIfNotInProgress()
    {
      if ((!(Application.Current.RootVisual is IPhoneApplicationFrame rootVisual) ? 0 : (rootVisual.IsNavigationInProgress ? 1 : 0)) != 0)
        return;
      Task rootTask = ApplicationHost.Current.RootTask;
      rootTask.OnNavigateAway = rootTask.OnNavigateAway + new ITask.NavigateAway(ChooserHelper.OnExternalNavigationBegin);
      ChooserHelper.IsExternalNavigationPending = true;
    }

    private static void OnExternalNavigationBegin(NavigationDirection direction)
    {
      Task rootTask = ApplicationHost.Current.RootTask;
      rootTask.OnNavigateAway = rootTask.OnNavigateAway - new ITask.NavigateAway(ChooserHelper.OnExternalNavigationBegin);
      ChooserHelper.IsExternalNavigationPending = false;
    }

    internal static bool NavigationInProgressGuard(Action action)
    {
      if (Deployment.Current != null && !Deployment.Current.Dispatcher.CheckAccess())
      {
        Deployment.Current.Dispatcher.BeginInvoke(action);
        return false;
      }
      return (!(Application.Current.RootVisual is IPhoneApplicationFrame rootVisual) || !rootVisual.IsNavigationInProgress) && !ChooserHelper.IsExternalNavigationPending;
    }

    internal static byte[] Serialize(ParameterPropertyBag ppb)
    {
      if (ppb == null)
        return (byte[]) null;
      uint serializedSize = ppb.SerializedSize;
      byte[] buffer = serializedSize <= 65536U ? new byte[(int) serializedSize] : throw new ArgumentOutOfRangeException("The size of input should not exceed 64K.");
      ppb.Serialize(buffer, serializedSize);
      return buffer;
    }

    [SecurityCritical]
    internal static string GetNewFilepath(string prefix, string extension) => ChooserHelper.GetNewFilepath(prefix + Guid.NewGuid().ToString() + extension);

    [SecurityCritical]
    internal static string GetNewFilepath(string fileName)
    {
      if (string.IsNullOrEmpty(ChooserHelper.platformDataFolderPath))
      {
        ChooserHelper.platformDataFolderPath = Path.Combine(new HostInfo().AppDataFolder, "PlatformData");
        Directory.CreateDirectory(ChooserHelper.platformDataFolderPath);
      }
      return Path.Combine(ChooserHelper.platformDataFolderPath, fileName);
    }

    [SecuritySafeCritical]
    internal static string CreateDestinationToken(string filePath)
    {
      string token = (string) null;
      int tokenForUserAccount = (int) ChooserHelper.CreateSharingTokenForUserAccount(filePath, false, out token);
      return token;
    }

    [SecuritySafeCritical]
    private static void TranscodeWrapper(StorageFile file, string destinationFilePath)
    {
      int applyExifInformation = (int) ChooserHelper.TranscodeToJpgAndApplyExifInformation((object) file, destinationFilePath);
    }

    [SecuritySafeCritical]
    private static bool NeedsJpegHardRotationWrapper(StorageFile file)
    {
      bool needsHardRotation = false;
      int num = (int) ChooserHelper.NeedsJpegHardRotation((object) file, out needsHardRotation);
      return needsHardRotation;
    }

    [SecuritySafeCritical]
    private static bool ApplicationOwnsFilePath(string filePath, bool shouldDelete)
    {
      if (!shouldDelete)
        return false;
      using (SafeHandle file = (SafeHandle) NativeMethods.CreateFile(filePath, 2147483648U, 1U, IntPtr.Zero, 4U, 128U, IntPtr.Zero))
        return !file.IsInvalid;
    }

    private static async Task TryDeleteStorageFile(StorageFile sf)
    {
      try
      {
        await sf.DeleteAsync();
      }
      catch (Exception ex)
      {
      }
    }

    internal static Task<PhotoResult> PropertyBagToPhotoResult(
      ParameterPropertyBag ppb,
      string filePrefix,
      bool shouldDeleteFile)
    {
      return (Task<PhotoResult>) Task.Run<PhotoResult>((Func<Task<M0>>) (async () =>
      {
        PhotoResult result = (PhotoResult) null;
        ParameterProperty property = ppb.GetProperty("SelectedTokens");
        if (property.ValueType == ParameterPropertyValueType.ValueType_String && !string.IsNullOrEmpty(property.StringValue))
        {
          TaskAwaiter<StorageFile> taskAwaiter1 = (TaskAwaiter<StorageFile>) WindowsRuntimeSystemExtensions.GetAwaiter<StorageFile>((IAsyncOperation<M0>) SharedStorageAccessManager.RedeemTokenForFileAsync(property.StringValue));
          if (!((TaskAwaiter<StorageFile>) ref taskAwaiter1).IsCompleted)
          {
            int num;
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = num = 0;
            TaskAwaiter<StorageFile> taskAwaiter = taskAwaiter1;
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            // ISSUE: cast to a reference type
            // ISSUE: cast to a reference type
            ((AsyncTaskMethodBuilder<PhotoResult>) ref (^this).\u003C\u003Et__builder).AwaitUnsafeOnCompleted<TaskAwaiter<StorageFile>, ChooserHelper.\u003C\u003Ec__DisplayClass25_0.\u003C\u003CPropertyBagToPhotoResult\u003Eb__0\u003Ed>((M0&) ref taskAwaiter1, (M1&) this);
            return;
          }
          StorageFile result1 = ((TaskAwaiter<StorageFile>) ref taskAwaiter1).GetResult();
          taskAwaiter1 = new TaskAwaiter<StorageFile>();
          StorageFile file = result1;
          string filePath = file.Path;
          bool flag = ChooserHelper.ApplicationOwnsFilePath(filePath, shouldDeleteFile);
          bool shouldDeleteTempFile = flag;
          try
          {
            result = new PhotoResult();
            if (QuirksMode.ShouldTranscodePhotosToJpg() || ChooserHelper.NeedsJpegHardRotationWrapper(file))
            {
              if (QuirksMode.ShouldPhotoStreamOpenWithDeleteOnCloseFlag())
              {
                filePath = ChooserHelper.GetNewFilepath(filePrefix, ".jpg");
              }
              else
              {
                string newFilepath = ChooserHelper.GetNewFilepath(ChooserHelper.ImagesDirectoryName);
                if (!Directory.Exists(newFilepath))
                  Directory.CreateDirectory(newFilepath);
                filePath = ChooserHelper.GetNewFilepath(Path.Combine(ChooserHelper.ImagesDirectoryName, filePrefix), ".jpg");
              }
              ChooserHelper.TranscodeWrapper(file, filePath);
              if (!QuirksMode.ShouldPhotoStreamOpenWithDeleteOnCloseFlag())
              {
                Task rootTask1 = ApplicationHost.Current.RootTask;
                rootTask1.OnClosing = rootTask1.OnClosing - new ITask.Closing(ChooserHelper.DeleteImages);
                Task rootTask2 = ApplicationHost.Current.RootTask;
                rootTask2.OnClosing = rootTask2.OnClosing + new ITask.Closing(ChooserHelper.DeleteImages);
                Task rootTask3 = ApplicationHost.Current.RootTask;
                rootTask3.OnHostDehydrating = rootTask3.OnHostDehydrating - new ITask.HostDehydrating(ChooserHelper.DeleteImages);
                Task rootTask4 = ApplicationHost.Current.RootTask;
                rootTask4.OnHostDehydrating = rootTask4.OnHostDehydrating + new ITask.HostDehydrating(ChooserHelper.DeleteImages);
              }
              result.ChosenPhoto = (Stream) new PhotoStream(filePath);
            }
            else if (flag)
            {
              result.ChosenPhoto = (Stream) new PhotoStream(filePath);
              shouldDeleteTempFile = false;
            }
            else
            {
              TaskAwaiter<IRandomAccessStreamWithContentType> taskAwaiter2 = (TaskAwaiter<IRandomAccessStreamWithContentType>) WindowsRuntimeSystemExtensions.GetAwaiter<IRandomAccessStreamWithContentType>((IAsyncOperation<M0>) file.OpenReadAsync());
              if (!((TaskAwaiter<IRandomAccessStreamWithContentType>) ref taskAwaiter2).IsCompleted)
              {
                int num;
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                (^this).\u003C\u003E1__state = num = 1;
                TaskAwaiter<IRandomAccessStreamWithContentType> taskAwaiter = taskAwaiter2;
                // ISSUE: explicit reference operation
                // ISSUE: reference to a compiler-generated field
                // ISSUE: cast to a reference type
                // ISSUE: cast to a reference type
                ((AsyncTaskMethodBuilder<PhotoResult>) ref (^this).\u003C\u003Et__builder).AwaitUnsafeOnCompleted<TaskAwaiter<IRandomAccessStreamWithContentType>, ChooserHelper.\u003C\u003Ec__DisplayClass25_0.\u003C\u003CPropertyBagToPhotoResult\u003Eb__0\u003Ed>((M0&) ref taskAwaiter2, (M1&) this);
                return;
              }
              IRandomAccessStreamWithContentType result2 = ((TaskAwaiter<IRandomAccessStreamWithContentType>) ref taskAwaiter2).GetResult();
              taskAwaiter2 = new TaskAwaiter<IRandomAccessStreamWithContentType>();
              result.ChosenPhoto = WindowsRuntimeStreamExtensions.AsStream((IRandomAccessStream) result2);
            }
          }
          finally
          {
            if (shouldDeleteTempFile)
              ChooserHelper.TryDeleteStorageFile(file);
          }
          if (QuirksMode.ShouldPhotoResultRemoveDriveLetterFromFilename() && filePath.Length > 2 && filePath.IndexOf(Path.VolumeSeparatorChar) == 1)
            filePath = filePath.Substring(2, filePath.Length - 2);
          result.OriginalFileName = filePath;
          file = (StorageFile) null;
          filePath = (string) null;
        }
        return result;
      }));
    }

    [SecuritySafeCritical]
    private static void DeleteImages()
    {
      string newFilepath = ChooserHelper.GetNewFilepath(ChooserHelper.ImagesDirectoryName);
      if (!Directory.Exists(newFilepath))
        return;
      try
      {
        Directory.Delete(newFilepath, true);
      }
      catch (IOException ex)
      {
      }
    }

    [DllImport("PlatformInterop.dll", PreserveSig = false)]
    private static extern uint TranscodeToJpgAndApplyExifInformation(
      [MarshalAs(UnmanagedType.IUnknown)] object fileObject,
      [MarshalAs(UnmanagedType.LPWStr)] string destinationFilePath);

    [DllImport("PlatformInterop.dll", PreserveSig = false)]
    private static extern uint NeedsJpegHardRotation([MarshalAs(UnmanagedType.IUnknown)] object fileObject, [MarshalAs(UnmanagedType.Bool)] out bool needsHardRotation);

    [DllImport("PlatformInterop.dll", PreserveSig = false)]
    private static extern uint LaunchUriAsChildTask([MarshalAs(UnmanagedType.LPWStr)] string uri, [MarshalAs(UnmanagedType.LPWStr)] string parameterData);

    [DllImport("PlatformInterop.dll", PreserveSig = false)]
    private static extern uint CreateSharingTokenForUserAccount(
      [MarshalAs(UnmanagedType.LPWStr)] string filePath,
      [MarshalAs(UnmanagedType.Bool)] bool readOnly,
      [MarshalAs(UnmanagedType.LPWStr)] out string token);
  }
}
