// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Storage.ExternalStorage
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.Phone.Storage
{
  public static class ExternalStorage
  {
    public static Task<IEnumerable<ExternalStorageDevice>> GetExternalStorageDevicesAsync() => Task<IEnumerable<ExternalStorageDevice>>.Factory.StartNew(new Func<IEnumerable<ExternalStorageDevice>>(ExternalStorage.GetExternalStorageDevices));

    private static IEnumerable<ExternalStorageDevice> GetExternalStorageDevices()
    {
      List<ExternalStorageDevice> externalStorageDeviceList = new List<ExternalStorageDevice>(1);
      string sdRootPath = "";
      if (SafeNativeMethods.SDGetRootDirectory(out sdRootPath) == 0 && !string.IsNullOrEmpty(sdRootPath))
        externalStorageDeviceList.Add(new ExternalStorageDevice(sdRootPath));
      return (IEnumerable<ExternalStorageDevice>) externalStorageDeviceList;
    }
  }
}
