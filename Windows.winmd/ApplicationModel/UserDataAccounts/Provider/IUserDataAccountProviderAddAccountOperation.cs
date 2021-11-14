// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.Provider.IUserDataAccountProviderAddAccountOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts.Provider
{
  [ExclusiveTo(typeof (UserDataAccountProviderAddAccountOperation))]
  [Guid(3116836144, 16260, 19293, 142, 170, 69, 233, 122, 168, 66, 237)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IUserDataAccountProviderAddAccountOperation : IUserDataAccountProviderOperation
  {
    UserDataAccountContentKinds ContentKinds { get; }

    IVectorView<UserDataAccountPartnerAccountInfo> PartnerAccountInfos { get; }

    void ReportCompleted(string userDataAccountId);
  }
}
