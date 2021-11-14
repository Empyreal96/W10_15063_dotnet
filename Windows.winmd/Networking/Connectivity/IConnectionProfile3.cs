// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.IConnectionProfile3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ExclusiveTo(typeof (ConnectionProfile))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1468802344, 19673, 16737, 128, 69, 32, 28, 253, 91, 17, 92)]
  internal interface IConnectionProfile3
  {
    [RemoteAsync]
    IAsyncOperation<IVectorView<AttributedNetworkUsage>> GetAttributedNetworkUsageAsync(
      DateTime startTime,
      DateTime endTime,
      NetworkUsageStates states);
  }
}
