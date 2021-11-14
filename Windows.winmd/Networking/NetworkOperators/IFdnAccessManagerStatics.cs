// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.IFdnAccessManagerStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ContractVersion(typeof (NetworkOperatorsFdnContract), 65536)]
  [ExclusiveTo(typeof (FdnAccessManager))]
  [Guid(4071244693, 61926, 17177, 170, 62, 71, 124, 166, 75, 43, 223)]
  internal interface IFdnAccessManagerStatics
  {
    [RemoteAsync]
    IAsyncOperation<bool> RequestUnlockAsync(string contactListId);
  }
}
