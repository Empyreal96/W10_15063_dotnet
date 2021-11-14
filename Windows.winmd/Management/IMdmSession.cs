// Decompiled with JetBrains decompiler
// Type: Windows.Management.IMdmSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management
{
  [Guid(4270403916, 36708, 18327, 169, 215, 157, 136, 248, 106, 225, 102)]
  [ExclusiveTo(typeof (MdmSession))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IMdmSession
  {
    IVectorView<MdmAlert> Alerts { get; }

    HResult ExtendedError { get; }

    string Id { get; }

    MdmSessionState State { get; }

    [RemoteAsync]
    IAsyncAction AttachAsync();

    void Delete();

    [Overload("StartAsync")]
    [RemoteAsync]
    IAsyncAction StartAsync();

    [Overload("StartWithAlertsAsync")]
    IAsyncAction StartAsync(IIterable<MdmAlert> alerts);
  }
}
