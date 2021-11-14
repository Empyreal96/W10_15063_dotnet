// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.UserDataAccounts.Provider.IUserDataAccountProviderOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.UserDataAccounts.Provider
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(2718608739, 34956, 19042, 163, 221, 52, 208, 122, 128, 43, 43)]
  public interface IUserDataAccountProviderOperation
  {
    UserDataAccountProviderOperationKind Kind { get; }
  }
}
