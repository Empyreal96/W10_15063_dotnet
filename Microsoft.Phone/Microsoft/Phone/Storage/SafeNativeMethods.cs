// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Storage.SafeNativeMethods
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Phone.Storage
{
  [SecurityCritical]
  internal static class SafeNativeMethods
  {
    internal const int Batch_Size = 50;
    internal const int S_OK = 0;
    internal const int S_FALSE = 1;
    private const int E_OUTOFMEMORY = -2147024882;
    private const int E_INVALIDARG = -2147024809;
    private const int E_HANDLE = -2147024890;
    private const int E_NOTIMPL = -2147467263;
    private const int E_ACCESSDENIED = -2147024891;
    private const int SDCARD_E_INVALID_PATH = -2129526773;
    private const int SDCARD_E_INVALID_BATCH_SIZE = -2129526772;
    private const int SDCARD_E_UNREGISTERED_FILE_EXTENSION = -2129526771;
    private const int SDCARD_E_FILE_NOT_FOUND = -2129526770;

    internal static void ThrowExceptionFromHResult(int hr)
    {
      switch (hr)
      {
        case -2147024891:
          throw new UnauthorizedAccessException("Access to removable storage requires ID_CAP_REMOVABLE_STORAGE to be defined in the manifest");
        case -2129526773:
        case -2129526771:
        case -2129526770:
          throw new FileNotFoundException("The File or Folder does not exist, or access is denied");
        default:
          Marshal.ThrowExceptionForHR(hr);
          break;
      }
    }

    [SecurityCritical]
    [DllImport("SDBrokerClient.dll", CallingConvention = CallingConvention.StdCall)]
    internal static extern int SDCreateDssToken(int key, [MarshalAs(UnmanagedType.LPWStr)] string filePath, [MarshalAs(UnmanagedType.LPWStr)] out string tokenID);

    [SecurityCritical]
    [DllImport("SDBrokerClient.dll", CallingConvention = CallingConvention.StdCall)]
    internal static extern int SDGetFirstBatchFiles(
      int key,
      [MarshalAs(UnmanagedType.LPWStr)] string folderPath,
      [MarshalAs(UnmanagedType.LPArray, SizeConst = 50)] out SafeNativeMethods.ManagedSDItem[] items);

    [SecurityCritical]
    [DllImport("SDBrokerClient.dll", CallingConvention = CallingConvention.StdCall)]
    internal static extern int SDGetNextBatchFiles(
      int key,
      [MarshalAs(UnmanagedType.LPWStr)] string folderPath,
      [MarshalAs(UnmanagedType.LPArray, SizeConst = 50)] out SafeNativeMethods.ManagedSDItem[] items);

    [SecurityCritical]
    [DllImport("SDBrokerClient.dll", CallingConvention = CallingConvention.StdCall)]
    internal static extern int SDGetFirstBatchFolders(
      int key,
      [MarshalAs(UnmanagedType.LPWStr)] string folderPath,
      [MarshalAs(UnmanagedType.LPArray, SizeConst = 50)] out SafeNativeMethods.ManagedSDItem[] items);

    [SecurityCritical]
    [DllImport("SDBrokerClient.dll", CallingConvention = CallingConvention.StdCall)]
    internal static extern int SDGetNextBatchFolders(
      int key,
      [MarshalAs(UnmanagedType.LPWStr)] string folderPath,
      [MarshalAs(UnmanagedType.LPArray, SizeConst = 50)] out SafeNativeMethods.ManagedSDItem[] items);

    [SecurityCritical]
    [DllImport("SDBrokerClient.dll", CallingConvention = CallingConvention.StdCall)]
    internal static extern int SDGetItem(
      int key,
      SafeNativeMethods.managedSdItemType type,
      [MarshalAs(UnmanagedType.LPWStr)] string folderPath,
      [MarshalAs(UnmanagedType.LPArray, SizeConst = 1)] out SafeNativeMethods.ManagedSDItem[] items);

    [SecurityCritical]
    [DllImport("SDBrokerClient.dll", CallingConvention = CallingConvention.StdCall)]
    internal static extern int SDCreateBrokerClientInstance(out int key);

    [SecurityCritical]
    [DllImport("SDBrokerClient.dll", CallingConvention = CallingConvention.StdCall)]
    internal static extern int SDDeleteBrokerClientInstance(int key);

    [SecurityCritical]
    [DllImport("SDBrokerClient.dll", CallingConvention = CallingConvention.StdCall)]
    internal static extern int SDGetRootDirectory([MarshalAs(UnmanagedType.LPWStr)] out string sdRootPath);

    [SecurityCritical]
    [DllImport("SDBrokerClient.dll", CallingConvention = CallingConvention.StdCall)]
    internal static extern int SDTestInterface();

    [SecurityCritical]
    [DllImport("dsclient.dll", CallingConvention = CallingConvention.StdCall)]
    internal static extern int DSOpenSharedFile(
      [MarshalAs(UnmanagedType.LPWStr)] string tokenId,
      int dwShareAttributes,
      out IntPtr handle);

    [SecurityCritical]
    [DllImport("SDBrokerClient.dll", CallingConvention = CallingConvention.StdCall)]
    internal static extern int SDGetStorageID(int deviceInstance, [MarshalAs(UnmanagedType.LPWStr)] out string deviceID);

    internal enum managedSdItemType
    {
      SD_TYPE_FILE,
      SD_TYPE_FOLDER,
      SD_TYPE_ITEM,
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct ManagedSDItem
    {
      public SafeNativeMethods.managedSdItemType type;
      [MarshalAs((UnmanagedType) 19)]
      public string name;
      public long fileTime;
    }
  }
}
