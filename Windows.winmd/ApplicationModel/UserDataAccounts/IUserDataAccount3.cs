// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.IUserDataAccount3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts
{
  [ExclusiveTo(typeof (UserDataAccount))]
  [Guid(22231109, 27715, 17030, 157, 105, 62, 23, 9, 161, 242, 102)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IUserDataAccount3
  {
    IVector<string> ExplictReadAccessPackageFamilyNames { get; }

    string DisplayName { get; set; }
  }
}
