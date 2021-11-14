// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.Provider.IUserDataAccountPartnerAccountInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts.Provider
{
  [ExclusiveTo(typeof (UserDataAccountPartnerAccountInfo))]
  [Guid(1595932727, 63215, 20163, 134, 48, 1, 44, 89, 193, 20, 159)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IUserDataAccountPartnerAccountInfo
  {
    string DisplayName { get; }

    uint Priority { get; }

    UserDataAccountProviderPartnerAccountKind AccountKind { get; }
  }
}
