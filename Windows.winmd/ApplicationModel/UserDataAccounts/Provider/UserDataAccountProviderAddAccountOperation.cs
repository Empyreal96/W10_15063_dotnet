// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.Provider.UserDataAccountProviderAddAccountOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts.Provider
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class UserDataAccountProviderAddAccountOperation : 
    IUserDataAccountProviderAddAccountOperation,
    IUserDataAccountProviderOperation
  {
    public extern UserDataAccountContentKinds ContentKinds { [MethodImpl] get; }

    public extern IVectorView<UserDataAccountPartnerAccountInfo> PartnerAccountInfos { [MethodImpl] get; }

    [MethodImpl]
    public extern void ReportCompleted(string userDataAccountId);

    public extern UserDataAccountProviderOperationKind Kind { [MethodImpl] get; }
  }
}
