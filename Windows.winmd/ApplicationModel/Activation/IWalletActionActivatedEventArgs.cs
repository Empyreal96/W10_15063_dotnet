// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IWalletActionActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.Wallet;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  [Guid(4244374139, 6682, 19746, 146, 63, 174, 111, 69, 250, 82, 217)]
  [ContractVersion(typeof (WalletContract), 65536)]
  public interface IWalletActionActivatedEventArgs : IActivatedEventArgs
  {
    string ItemId { get; }

    WalletActionKind ActionKind { get; }

    string ActionId { get; }
  }
}
