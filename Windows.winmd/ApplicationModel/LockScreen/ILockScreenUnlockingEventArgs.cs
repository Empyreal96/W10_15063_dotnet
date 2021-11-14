// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.LockScreen.ILockScreenUnlockingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.LockScreen
{
  [Guid(1155973127, 30203, 19131, 159, 139, 130, 71, 72, 144, 12, 113)]
  [ExclusiveTo(typeof (LockScreenUnlockingEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ILockScreenUnlockingEventArgs
  {
    LockScreenUnlockingDeferral GetDeferral();

    DateTime Deadline { get; }
  }
}
