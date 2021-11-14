// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynSession
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [Guid(3906018060, 49364, 16492, 136, 169, 169, 62, 250, 133, 212, 177)]
  [ExclusiveTo(typeof (AllJoynSession))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAllJoynSession
  {
    int Id { get; }

    int Status { get; }

    [RemoteAsync]
    IAsyncOperation<int> RemoveMemberAsync(string uniqueName);

    event TypedEventHandler<AllJoynSession, AllJoynSessionMemberAddedEventArgs> MemberAdded;

    event TypedEventHandler<AllJoynSession, AllJoynSessionMemberRemovedEventArgs> MemberRemoved;

    event TypedEventHandler<AllJoynSession, AllJoynSessionLostEventArgs> Lost;
  }
}
