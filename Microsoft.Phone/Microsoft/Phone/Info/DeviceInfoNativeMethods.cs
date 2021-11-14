// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Info.DeviceInfoNativeMethods
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace Microsoft.Phone.Info
{
  [SecurityCritical]
  internal static class DeviceInfoNativeMethods
  {
    [DllImport("PlatformInterop.dll", EntryPoint = "DevicePropertiesGetUniqueDeviceId", PreserveSig = false)]
    internal static extern void GetUniqueDeviceId(byte[] deviceId, uint cbDeviceId);

    [DllImport("PlatformInterop.dll", EntryPoint = "DevicePropertiesGetProcessMemoryInfo", SetLastError = true)]
    public static extern bool GetProcessMemoryInfo(
      ref DeviceInfoNativeMethods.ProcMemCounter processMemoryCounters,
      uint size);

    [DllImport("PlatformInterop.dll", EntryPoint = "DevicePropertiesGlobalMemoryStatus", SetLastError = true)]
    public static extern void GlobalMemoryStatus(ref DeviceInfoNativeMethods.MEMORYSTATUS lpBuffer);

    [DllImport("PlatformInterop.dll", EntryPoint = "DeviceQueryPhoneInformation", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern bool QueryPhoneInformation(int key, StringBuilder value, int inSize);

    [DllImport("rmclient.dll")]
    public static extern int SHGetResourceManagementValue(
      DeviceInfoNativeMethods.ResourceManagementValue rmv,
      out ulong outvalue);

    [DllImport("PlatformInterop.dll", SetLastError = true)]
    public static extern int IsApplicationPreInstalled(out bool bisAppPreInstall);

    [DllImport("PlatformInterop.dll", EntryPoint = "DevicePropertiesGetPhysicalScreenResolution", SetLastError = true)]
    public static extern int GetPhysicalScreenResolution(out int dwWidth, out int dwHeight);

    [DllImport("PlatformInterop.dll", EntryPoint = "DevicePropertiesGetRawDPI", SetLastError = true)]
    public static extern int GetRawDPI(out double dblRawDpi);

    public enum PhoneKeys
    {
      DeviceMobileOperatorName = 2,
      DeviceName = 5,
      DeviceHardwareVersion = 6,
      DeviceFirmwareVersion = 8,
      DeviceManufacturer = 17, // 0x00000011
    }

    public struct ProcMemCounter
    {
      public uint size;
      public uint pageFaultCount;
      public UIntPtr PeakWorkingSetSize;
      public UIntPtr WorkingSetSize;
      public UIntPtr QuotaPeakPagedPoolUsage;
      public UIntPtr QuotaPagedPoolUsage;
      public UIntPtr QuotaPeakNonPagedPoolUsage;
      public UIntPtr QuotaNonPagedPoolUsage;
      public UIntPtr PagefileUsage;
      public UIntPtr PeakPagefileUsage;
      public UIntPtr PrivateUsage;
    }

    public struct MEMORYSTATUS
    {
      public uint dwLength;
      public uint dwMemoryLoad;
      public ulong ullTotalPhys;
      public ulong ullAvailPhys;
      public ulong ullTotalPageFile;
      public ulong ullAvailPageFile;
      public ulong ullTotalVirtual;
      public ulong ullAvailVirtual;
      public ulong ullAvailExtendedVirtual;
    }

    public enum ResourceManagementValue
    {
      RMV_MAXWORKINGSET = 8,
    }
  }
}
