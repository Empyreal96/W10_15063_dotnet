// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.WalletActionActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.Wallet;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (WalletContract), 65536)]
  public sealed class WalletActionActivatedEventArgs : 
    IWalletActionActivatedEventArgs,
    IActivatedEventArgs
  {
    public extern string ItemId { [MethodImpl] get; }

    public extern WalletActionKind ActionKind { [MethodImpl] get; }

    public extern string ActionId { [MethodImpl] get; }

    public extern ActivationKind Kind { [MethodImpl] get; }

    public extern ApplicationExecutionState PreviousExecutionState { [MethodImpl] get; }

    public extern SplashScreen SplashScreen { [MethodImpl] get; }
  }
}
