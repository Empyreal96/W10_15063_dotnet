// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Info.DeviceExtendedProperties
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Windows;

namespace Microsoft.Phone.Info
{
  [SecuritySafeCritical]
  public static class DeviceExtendedProperties
  {
    private const string totalMemoryRegKeyPath = "Software\\Microsoft\\AppPlatform";
    private const string totalMemoryRegValueName = "OverrideDeviceMemoryAPI";

    public static object GetValue(string propertyName) => ExtendedPropertiesHelper.GetValue(propertyName, new GetValueImplDelegate(DeviceExtendedProperties.GetValueImpl));

    public static bool TryGetValue(string propertyName, out object propertyValue) => ExtendedPropertiesHelper.TryGetValue(propertyName, out propertyValue, new GetValueImplDelegate(DeviceExtendedProperties.GetValueImpl));

    internal static bool GetValueImpl(string propertyName, out object propertyValue)
    {
      bool flag = true;
      propertyValue = (object) null;
      if ("DeviceManufacturer" == propertyName)
      {
        StringBuilder stringBuilder1 = new StringBuilder(256);
        StringBuilder stringBuilder2 = stringBuilder1;
        if (DeviceInfoNativeMethods.QueryPhoneInformation(17, stringBuilder2, stringBuilder2.Capacity))
          propertyValue = (object) stringBuilder1.ToString();
      }
      else if ("DeviceName" == propertyName)
      {
        StringBuilder stringBuilder1 = new StringBuilder(256);
        StringBuilder stringBuilder2 = stringBuilder1;
        if (DeviceInfoNativeMethods.QueryPhoneInformation(5, stringBuilder2, stringBuilder2.Capacity))
          propertyValue = !(stringBuilder1.ToString() == "Virtual") ? (object) stringBuilder1.ToString() : (object) "XDeviceEmulator";
      }
      else if ("DeviceUniqueId" == propertyName)
      {
        byte[] numArray = new byte[20];
        byte[] deviceId = numArray;
        DeviceInfoNativeMethods.GetUniqueDeviceId(deviceId, (uint) deviceId.Length);
        propertyValue = (object) numArray;
      }
      else if ("DeviceFirmwareVersion" == propertyName)
      {
        StringBuilder stringBuilder1 = new StringBuilder(256);
        StringBuilder stringBuilder2 = stringBuilder1;
        if (DeviceInfoNativeMethods.QueryPhoneInformation(8, stringBuilder2, stringBuilder2.Capacity))
          propertyValue = (object) stringBuilder1.ToString();
      }
      else if ("DeviceHardwareVersion" == propertyName)
      {
        StringBuilder stringBuilder1 = new StringBuilder(256);
        StringBuilder stringBuilder2 = stringBuilder1;
        if (DeviceInfoNativeMethods.QueryPhoneInformation(6, stringBuilder2, stringBuilder2.Capacity))
          propertyValue = (object) stringBuilder1.ToString();
      }
      else if ("OriginalMobileOperatorName" == propertyName)
      {
        StringBuilder stringBuilder1 = new StringBuilder(256);
        StringBuilder stringBuilder2 = stringBuilder1;
        if (DeviceInfoNativeMethods.QueryPhoneInformation(2, stringBuilder2, stringBuilder2.Capacity))
          propertyValue = (object) stringBuilder1.ToString();
      }
      else if ("DeviceTotalMemory" == propertyName)
      {
        uint propertyValue1 = 0;
        int num = Registry.QueryDwordValue(2147483650U, "Software\\Microsoft\\AppPlatform", "OverrideDeviceMemoryAPI", ref propertyValue1) ? 1 : 0;
        propertyValue = (object) (long) propertyValue1;
        if (num == 0)
        {
          DeviceInfoNativeMethods.MEMORYSTATUS lpBuffer = new DeviceInfoNativeMethods.MEMORYSTATUS();
          lpBuffer.dwLength = (uint) Marshal.SizeOf((object) lpBuffer);
          DeviceInfoNativeMethods.GlobalMemoryStatus(ref lpBuffer);
          propertyValue = (object) (long) lpBuffer.ullTotalPhys;
        }
        if ((long) propertyValue > (long) int.MaxValue)
          propertyValue = (object) (long) int.MaxValue;
      }
      else if ("ApplicationCurrentMemoryUsage" == propertyName)
      {
        DeviceInfoNativeMethods.ProcMemCounter procMemCounter;
        flag = DeviceExtendedProperties.GetProcessMemoryInfo(out procMemCounter);
        if (flag)
          propertyValue = (object) (long) (ulong) procMemCounter.PagefileUsage;
      }
      else if ("ApplicationPeakMemoryUsage" == propertyName)
      {
        DeviceInfoNativeMethods.ProcMemCounter procMemCounter;
        flag = DeviceExtendedProperties.GetProcessMemoryInfo(out procMemCounter);
        if (flag)
          propertyValue = (object) (long) (ulong) procMemCounter.PeakPagefileUsage;
      }
      else if ("ApplicationWorkingSetLimit" == propertyName)
      {
        ulong outvalue;
        flag = DeviceInfoNativeMethods.SHGetResourceManagementValue(DeviceInfoNativeMethods.ResourceManagementValue.RMV_MAXWORKINGSET, out outvalue) >= 0;
        if (flag)
          propertyValue = (object) (long) outvalue;
      }
      else if ("IsApplicationPreInstalled" == propertyName)
      {
        bool bisAppPreInstall = false;
        flag = DeviceInfoNativeMethods.IsApplicationPreInstalled(out bisAppPreInstall) >= 0;
        if (flag)
          propertyValue = (object) bisAppPreInstall;
      }
      else if ("IsMpeg2TsParsingAvailable" == propertyName)
      {
        flag = true;
        propertyValue = (object) true;
      }
      else if ("PhysicalScreenResolution" == propertyName)
      {
        int dwWidth = 0;
        int dwHeight = 0;
        flag = DeviceInfoNativeMethods.GetPhysicalScreenResolution(out dwWidth, out dwHeight) >= 0 && dwWidth > 0 && dwHeight > 0;
        if (flag)
          propertyValue = (object) new Size()
          {
            Width = (double) dwWidth,
            Height = (double) dwHeight
          };
      }
      else if ("RawDpiX" == propertyName)
      {
        double dblRawDpi;
        flag = DeviceInfoNativeMethods.GetRawDPI(out dblRawDpi) >= 0;
        if (flag)
          propertyValue = (object) dblRawDpi;
      }
      else if ("RawDpiY" == propertyName)
      {
        double dblRawDpi;
        flag = DeviceInfoNativeMethods.GetRawDPI(out dblRawDpi) >= 0;
        if (flag)
          propertyValue = (object) dblRawDpi;
      }
      else
        flag = false;
      return flag;
    }

    private static bool GetProcessMemoryInfo(
      out DeviceInfoNativeMethods.ProcMemCounter procMemCounter)
    {
      procMemCounter = new DeviceInfoNativeMethods.ProcMemCounter();
      procMemCounter.size = (uint) Marshal.SizeOf((object) procMemCounter);
      ref DeviceInfoNativeMethods.ProcMemCounter local = ref procMemCounter;
      return DeviceInfoNativeMethods.GetProcessMemoryInfo(ref local, local.size);
    }
  }
}
