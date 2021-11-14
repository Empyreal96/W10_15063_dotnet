// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.IUserDataAccount2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts
{
  [ExclusiveTo(typeof (UserDataAccount))]
  [Guid(126671007, 56962, 16459, 129, 149, 200, 163, 172, 25, 143, 96)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IUserDataAccount2 : IUserDataAccount
  {
    string EnterpriseId { get; }

    bool IsProtectedUnderLock { get; }
  }
}
