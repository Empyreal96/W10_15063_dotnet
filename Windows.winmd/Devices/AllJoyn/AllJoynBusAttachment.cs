// Decompiled with JetBrains decompiler
// Type: Windows.Devices.AllJoyn.AllJoynBusAttachment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Devices.Enumeration;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.Devices.AllJoyn
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IAllJoynBusAttachmentStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IAllJoynBusAttachmentFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class AllJoynBusAttachment : IAllJoynBusAttachment, IAllJoynBusAttachment2
  {
    [MethodImpl]
    public extern AllJoynBusAttachment(string connectionSpecification);

    [MethodImpl]
    public extern AllJoynBusAttachment();

    public extern AllJoynAboutData AboutData { [MethodImpl] get; }

    public extern string ConnectionSpecification { [MethodImpl] get; }

    public extern AllJoynBusAttachmentState State { [MethodImpl] get; }

    public extern string UniqueName { [MethodImpl] get; }

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<int> PingAsync(string uniqueName);

    [MethodImpl]
    public extern void Connect();

    [MethodImpl]
    public extern void Disconnect();

    public extern event TypedEventHandler<AllJoynBusAttachment, AllJoynBusAttachmentStateChangedEventArgs> StateChanged;

    public extern IVector<AllJoynAuthenticationMechanism> AuthenticationMechanisms { [MethodImpl] get; }

    public extern event TypedEventHandler<AllJoynBusAttachment, AllJoynCredentialsRequestedEventArgs> CredentialsRequested;

    public extern event TypedEventHandler<AllJoynBusAttachment, AllJoynCredentialsVerificationRequestedEventArgs> CredentialsVerificationRequested;

    public extern event TypedEventHandler<AllJoynBusAttachment, AllJoynAuthenticationCompleteEventArgs> AuthenticationComplete;

    [Overload("GetAboutDataAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AllJoynAboutDataView> GetAboutDataAsync(
      AllJoynServiceInfo serviceInfo);

    [Overload("GetAboutDataWithLanguageAsync")]
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<AllJoynAboutDataView> GetAboutDataAsync(
      AllJoynServiceInfo serviceInfo,
      Language language);

    public extern event TypedEventHandler<AllJoynBusAttachment, AllJoynAcceptSessionJoinerEventArgs> AcceptSessionJoinerRequested;

    public extern event TypedEventHandler<AllJoynBusAttachment, AllJoynSessionJoinedEventArgs> SessionJoined;

    [MethodImpl]
    public static extern AllJoynBusAttachment GetDefault();

    [MethodImpl]
    public static extern DeviceWatcher GetWatcher(IIterable<string> requiredInterfaces);
  }
}
