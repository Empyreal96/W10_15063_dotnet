// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Activation.IUserDataAccountProviderActivatedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.UserDataAccounts.Provider;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Activation
{
  [Guid(466220835, 36593, 19025, 166, 58, 254, 113, 30, 234, 182, 7)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public interface IUserDataAccountProviderActivatedEventArgs : IActivatedEventArgs
  {
    IUserDataAccountProviderOperation Operation { get; }
  }
}
