// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [Static(typeof (IAllJoynSessionStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public sealed class AllJoynSession : IAllJoynSession
  {
    public extern int Id { [MethodImpl] get; }

    public extern int Status { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<int> RemoveMemberAsync(string uniqueName);

    public extern event TypedEventHandler<AllJoynSession, AllJoynSessionMemberAddedEventArgs> MemberAdded;

    public extern event TypedEventHandler<AllJoynSession, AllJoynSessionMemberRemovedEventArgs> MemberRemoved;

    public extern event TypedEventHandler<AllJoynSession, AllJoynSessionLostEventArgs> Lost;

    [Overload("GetFromServiceInfoAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<AllJoynSession> GetFromServiceInfoAsync(
      AllJoynServiceInfo serviceInfo);

    [Overload("GetFromServiceInfoAndBusAttachmentAsync")]
    [RemoteAsync]
    [MethodImpl]
    public static extern IAsyncOperation<AllJoynSession> GetFromServiceInfoAsync(
      AllJoynServiceInfo serviceInfo,
      AllJoynBusAttachment busAttachment);
  }
}
