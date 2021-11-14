// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.Provider.IUserDataAccountProviderResolveErrorsOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts.Provider
{
  [ExclusiveTo(typeof (UserDataAccountProviderResolveErrorsOperation))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1647696917, 49099, 16865, 153, 87, 151, 89, 162, 136, 70, 204)]
  internal interface IUserDataAccountProviderResolveErrorsOperation : 
    IUserDataAccountProviderOperation
  {
    string UserDataAccountId { get; }

    void ReportCompleted();
  }
}
