// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Info.SubscriptionHandler
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using System.Windows;

namespace Microsoft.Phone.Info
{
  internal class SubscriptionHandler
  {
    private static bool isInitialized;
    private DeviceTypes deviceType;
    private int lastValue;
    private IntPtr notifyHandle = new IntPtr(0);
    private SubscriptionHandler.ValueChangedDelegate callback;

    public SubscriptionHandler(DeviceTypes deviceType) => this.deviceType = deviceType;

    ~SubscriptionHandler() => this.Unregister();

    public event EventHandler Changed
    {
      add
      {
        if (this.changed == null)
          this.Register();
        this.changed += value;
      }
      remove
      {
        this.changed -= value;
        if (this.changed != null)
          return;
        this.Unregister();
      }
    }

    [SecuritySafeCritical]
    public static int GetCurrentValue(DeviceTypes dt)
    {
      int dwData = 0;
      return DeviceStatusInterop.GetCurrentValue(dt, ref dwData) == 0 ? dwData : throw new SystemException();
    }

    [AllowReversePInvokeCalls]
    private void ValueChanged(bool doEventFire)
    {
      try
      {
        int currentValue = SubscriptionHandler.GetCurrentValue(this.deviceType);
        if (doEventFire && currentValue != this.lastValue)
          new Thread((ThreadStart) (() =>
          {
            EventHandler changed = this.changed;
            if (changed == null)
              return;
            changed((object) this, (EventArgs) null);
          }))
          {
            IsBackground = true
          }.Start();
        this.lastValue = currentValue;
      }
      catch (Exception ex)
      {
        if (Application.ShouldIgnoreUnhandledException(ex))
          return;
        throw;
      }
    }

    [SecuritySafeCritical]
    private void Register()
    {
      SubscriptionHandler.InitializeSubscription();
      this.callback = new SubscriptionHandler.ValueChangedDelegate(this.ValueChanged);
      this.lastValue = SubscriptionHandler.GetCurrentValue(this.deviceType);
      if (DeviceStatusInterop.StartSubscriptionCallback(this.deviceType, Marshal.GetFunctionPointerForDelegate((Delegate) this.callback), ref this.notifyHandle) != 0)
        throw new SystemException();
    }

    [SecuritySafeCritical]
    private void Unregister()
    {
      if (!(this.notifyHandle != IntPtr.Zero))
        return;
      DeviceStatusInterop.StopSubscriptionCallback(this.notifyHandle);
      this.notifyHandle = IntPtr.Zero;
      this.callback = (SubscriptionHandler.ValueChangedDelegate) null;
    }

    [SecuritySafeCritical]
    private static void InitializeSubscription()
    {
      lock (typeof (SubscriptionHandler))
      {
        if (SubscriptionHandler.isInitialized)
          return;
        if (DeviceStatusInterop.SubscriptionInitialize() != 0)
          throw new SystemException();
        SubscriptionHandler.isInitialized = true;
      }
    }

    private event EventHandler changed;

    private delegate void ValueChangedDelegate(bool doEventFire);
  }
}
