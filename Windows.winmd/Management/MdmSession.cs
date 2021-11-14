// Decompiled with JetBrains decompiler
// Type: Windows.Management.MdmSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Management
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public sealed class MdmSession : IMdmSession
  {
    public extern IVectorView<MdmAlert> Alerts { [MethodImpl] get; }

    public extern HResult ExtendedError { [MethodImpl] get; }

    public extern string Id { [MethodImpl] get; }

    public extern MdmSessionState State { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction AttachAsync();

    [MethodImpl]
    public extern void Delete();

    [Overload("StartAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction StartAsync();

    [Overload("StartWithAlertsAsync")]
    [MethodImpl]
    public extern IAsyncAction StartAsync(IIterable<MdmAlert> alerts);
  }
}
