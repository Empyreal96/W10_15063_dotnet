// Decompiled with JetBrains decompiler
// Type: Windows.Phone.System.UserProfile.LockScreenManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Phone.System.UserProfile
{
  [Static(typeof (ILockScreenManagerStatics), 65536, "Windows.Phone.PhoneInternalContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  public static class LockScreenManager
  {
    public static extern bool IsProvidedByCurrentApplication { [MethodImpl] get; }

    [MethodImpl]
    public static extern IAsyncOperation<LockScreenRequestResult> RequestAccessAsync();
  }
}
