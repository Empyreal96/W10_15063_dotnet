// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.Provider.IUserDataAccountProviderSettingsOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2449690039, 34376, 20272, 172, 250, 48, 2, 101, 140, 168, 13)]
  [ExclusiveTo(typeof (UserDataAccountProviderSettingsOperation))]
  internal interface IUserDataAccountProviderSettingsOperation : IUserDataAccountProviderOperation
  {
    string UserDataAccountId { get; }

    void ReportCompleted();
  }
}
