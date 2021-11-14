// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.System.IWalletItemSystemStore2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet.System
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4186782286, 48640, 20445, 151, 52, 108, 17, 60, 26, 193, 203)]
  [ExclusiveTo(typeof (WalletItemSystemStore))]
  internal interface IWalletItemSystemStore2
  {
    event TypedEventHandler<WalletItemSystemStore, object> ItemsChanged;
  }
}
