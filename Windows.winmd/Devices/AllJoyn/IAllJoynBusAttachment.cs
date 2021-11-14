// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.IAllJoynBusAttachment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Devices.AllJoyn
{
  [ExclusiveTo(typeof (AllJoynBusAttachment))]
  [Guid(4077515091, 7917, 17091, 162, 14, 67, 109, 65, 254, 98, 246)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IAllJoynBusAttachment
  {
    AllJoynAboutData AboutData { get; }

    string ConnectionSpecification { get; }

    AllJoynBusAttachmentState State { get; }

    string UniqueName { get; }

    [RemoteAsync]
    IAsyncOperation<int> PingAsync(string uniqueName);

    void Connect();

    void Disconnect();

    event TypedEventHandler<AllJoynBusAttachment, AllJoynBusAttachmentStateChangedEventArgs> StateChanged;

    IVector<AllJoynAuthenticationMechanism> AuthenticationMechanisms { get; }

    event TypedEventHandler<AllJoynBusAttachment, AllJoynCredentialsRequestedEventArgs> CredentialsRequested;

    event TypedEventHandler<AllJoynBusAttachment, AllJoynCredentialsVerificationRequestedEventArgs> CredentialsVerificationRequested;

    event TypedEventHandler<AllJoynBusAttachment, AllJoynAuthenticationCompleteEventArgs> AuthenticationComplete;
  }
}
