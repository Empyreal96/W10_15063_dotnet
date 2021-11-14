// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.WalletTransaction
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class WalletTransaction : IWalletTransaction
  {
    [MethodImpl]
    public extern WalletTransaction();

    public extern string Description { [MethodImpl] get; [MethodImpl] set; }

    public extern string DisplayAmount { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IgnoreTimeOfDay { [MethodImpl] get; [MethodImpl] set; }

    public extern string DisplayLocation { [MethodImpl] get; [MethodImpl] set; }

    public extern IReference<DateTime> TransactionDate { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsLaunchable { [MethodImpl] get; [MethodImpl] set; }
  }
}
