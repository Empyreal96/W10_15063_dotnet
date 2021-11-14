// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.SystemAccess.IUserDataAccountSystemAccessManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts.SystemAccess
{
  [Guid(2641039801, 52197, 17909, 130, 43, 194, 103, 184, 29, 189, 182)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UserDataAccountSystemAccessManager))]
  internal interface IUserDataAccountSystemAccessManagerStatics
  {
    IAsyncOperation<IVectorView<string>> AddAndShowDeviceAccountsAsync(
      IIterable<DeviceAccountConfiguration> accounts);
  }
}
