// Decompiled with JetBrains decompiler
// Type: Windows.System.UserPicker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [DualApiPartition(version = 167772162)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IUserPickerStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [Activatable(196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class UserPicker : IUserPicker
  {
    [MethodImpl]
    public extern UserPicker();

    public extern bool AllowGuestAccounts { [MethodImpl] get; [MethodImpl] set; }

    public extern User SuggestedSelectedUser { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern IAsyncOperation<User> PickSingleUserAsync();

    [MethodImpl]
    public static extern bool IsSupported();
  }
}
