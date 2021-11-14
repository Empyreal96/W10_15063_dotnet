// Decompiled with JetBrains decompiler
// Type: Windows.Phone.System.LockScreenExtensibility.ILockScreenExtensibilityStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.System.LockScreenExtensibility
{
  [Guid(1957027370, 13452, 19203, 153, 36, 241, 236, 214, 109, 97, 68)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (ExtensibilityApp))]
  internal interface ILockScreenExtensibilityStatics
  {
    void RegisterLockScreenApplication();

    void UnregisterLockScreenApplication();

    bool IsLockScreenApplicationRegistered();

    void RegisterSystemOverlayApplication();

    void UnregisterSystemOverlayApplication();

    bool IsSystemOverlayApplicationRegistered();

    int GetLockPinpadHeight();

    void BeginUnlock();

    void EndUnlock();

    void RaiseToastNotifications();
  }
}
