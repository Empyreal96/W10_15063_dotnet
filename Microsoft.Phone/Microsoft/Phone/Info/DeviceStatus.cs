// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Info.DeviceStatus
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Security;

namespace Microsoft.Phone.Info
{
  public static class DeviceStatus
  {
    private const string keyboardRegKeyPath = "Software\\Microsoft\\Input\\State";
    private const string regKeyKbStatusValueName = "HardwareKeyboardExists";
    private static SubscriptionHandler KeyboardDeployedSubscription;
    private static SubscriptionHandler PowerSourceSubscription;

    public static event EventHandler KeyboardDeployedChanged
    {
      [SecuritySafeCritical] add
      {
        if (DeviceStatus.KeyboardDeployedSubscription == null)
          DeviceStatus.KeyboardDeployedSubscription = new SubscriptionHandler(DeviceTypes.KeyBoard);
        DeviceStatus.KeyboardDeployedSubscription.Changed += value;
      }
      [SecuritySafeCritical] remove => DeviceStatus.KeyboardDeployedSubscription.Changed -= value;
    }

    public static event EventHandler PowerSourceChanged
    {
      [SecuritySafeCritical] add
      {
        if (DeviceStatus.PowerSourceSubscription == null)
          DeviceStatus.PowerSourceSubscription = new SubscriptionHandler(DeviceTypes.PowerSource);
        DeviceStatus.PowerSourceSubscription.Changed += value;
      }
      [SecuritySafeCritical] remove => DeviceStatus.PowerSourceSubscription.Changed -= value;
    }

    public static bool IsKeyboardDeployed => SubscriptionHandler.GetCurrentValue(DeviceTypes.KeyBoard) == 1;

    public static bool IsKeyboardPresent
    {
      get
      {
        uint propertyValue = 0;
        return Registry.QueryDwordValue(2147483650U, "Software\\Microsoft\\Input\\State", "HardwareKeyboardExists", ref propertyValue) && propertyValue > 0U;
      }
    }

    public static PowerSource PowerSource
    {
      [SecuritySafeCritical] get => SubscriptionHandler.GetCurrentValue(DeviceTypes.PowerSource) == 0 ? PowerSource.External : PowerSource.Battery;
    }

    public static long ApplicationCurrentMemoryUsage => (long) DeviceExtendedProperties.GetValue(nameof (ApplicationCurrentMemoryUsage));

    public static long ApplicationPeakMemoryUsage => (long) DeviceExtendedProperties.GetValue(nameof (ApplicationPeakMemoryUsage));

    public static long ApplicationMemoryUsageLimit
    {
      [SecuritySafeCritical] get => DeviceStatusInterop.GetMemoryUsageLimit();
    }

    public static long DeviceTotalMemory => (long) DeviceExtendedProperties.GetValue(nameof (DeviceTotalMemory));

    public static string DeviceName => (string) DeviceExtendedProperties.GetValue(nameof (DeviceName));

    public static string DeviceFirmwareVersion => (string) DeviceExtendedProperties.GetValue(nameof (DeviceFirmwareVersion));

    public static string DeviceHardwareVersion => (string) DeviceExtendedProperties.GetValue(nameof (DeviceHardwareVersion));

    public static string DeviceManufacturer => (string) DeviceExtendedProperties.GetValue(nameof (DeviceManufacturer));
  }
}
