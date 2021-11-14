// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.IUserDataAccountStoreChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2229527269, 34848, 17682, 177, 246, 46, 3, 91, 225, 7, 44)]
  [ExclusiveTo(typeof (UserDataAccountStoreChangedEventArgs))]
  internal interface IUserDataAccountStoreChangedEventArgs
  {
    Deferral GetDeferral();
  }
}
