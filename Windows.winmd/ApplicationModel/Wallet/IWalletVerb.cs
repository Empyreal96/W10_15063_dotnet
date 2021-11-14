// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Wallet.IWalletVerb
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Wallet
{
  [ExclusiveTo(typeof (WalletVerb))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(397944534, 58305, 19572, 138, 148, 33, 122, 173, 188, 72, 132)]
  internal interface IWalletVerb
  {
    string Name { get; set; }
  }
}
