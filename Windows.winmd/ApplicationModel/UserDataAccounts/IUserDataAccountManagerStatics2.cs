// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.IUserDataAccountManagerStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.ApplicationModel.UserDataAccounts
{
  [ExclusiveTo(typeof (UserDataAccountManager))]
  [Guid(1782443400, 12651, 17246, 181, 52, 247, 212, 180, 183, 219, 166)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IUserDataAccountManagerStatics2
  {
    UserDataAccountManagerForUser GetForUser(User user);
  }
}
