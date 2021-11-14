// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.Provider.UserDataAccountProviderResolveErrorsOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UserDataAccountProviderResolveErrorsOperation : 
    IUserDataAccountProviderResolveErrorsOperation,
    IUserDataAccountProviderOperation
  {
    public extern string UserDataAccountId { [MethodImpl] get; }

    [MethodImpl]
    public extern void ReportCompleted();

    public extern UserDataAccountProviderOperationKind Kind { [MethodImpl] get; }
  }
}
