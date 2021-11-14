// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.LockScreen.ILockApplicationHost
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.LockScreen
{
  [Guid(955134381, 55631, 20092, 129, 250, 79, 68, 54, 80, 98, 129)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (LockApplicationHost))]
  internal interface ILockApplicationHost
  {
    void RequestUnlock();

    event TypedEventHandler<LockApplicationHost, LockScreenUnlockingEventArgs> Unlocking;
  }
}
