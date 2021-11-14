// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.VoiceCommandServiceConnection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.ApplicationModel.AppService;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.ApplicationModel.VoiceCommands
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IVoiceCommandServiceConnectionStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class VoiceCommandServiceConnection : IVoiceCommandServiceConnection
  {
    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VoiceCommand> GetVoiceCommandAsync();

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VoiceCommandConfirmationResult> RequestConfirmationAsync(
      VoiceCommandResponse response);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncOperation<VoiceCommandDisambiguationResult> RequestDisambiguationAsync(
      VoiceCommandResponse response);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportProgressAsync(VoiceCommandResponse response);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportSuccessAsync(VoiceCommandResponse response);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction ReportFailureAsync(VoiceCommandResponse response);

    [RemoteAsync]
    [MethodImpl]
    public extern IAsyncAction RequestAppLaunchAsync(VoiceCommandResponse response);

    public extern Language Language { [MethodImpl] get; }

    public extern event TypedEventHandler<VoiceCommandServiceConnection, VoiceCommandCompletedEventArgs> VoiceCommandCompleted;

    [MethodImpl]
    public static extern VoiceCommandServiceConnection FromAppServiceTriggerDetails(
      AppServiceTriggerDetails triggerDetails);
  }
}
