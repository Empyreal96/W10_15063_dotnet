// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.LockScreen.LockApplicationHost
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.LockScreen
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (ILockApplicationHostStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  public sealed class LockApplicationHost : ILockApplicationHost
  {
    [MethodImpl]
    public extern void RequestUnlock();

    public extern event TypedEventHandler<LockApplicationHost, LockScreenUnlockingEventArgs> Unlocking;

    [MethodImpl]
    public static extern LockApplicationHost GetForCurrentView();
  }
}
