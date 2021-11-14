// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.IVoiceCommandServiceConnection
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Globalization;

namespace Windows.ApplicationModel.VoiceCommands
{
  [Guid(3633626015, 8666, 17572, 152, 162, 251, 19, 25, 32, 169, 204)]
  [ExclusiveTo(typeof (VoiceCommandServiceConnection))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVoiceCommandServiceConnection
  {
    [RemoteAsync]
    IAsyncOperation<VoiceCommand> GetVoiceCommandAsync();

    [RemoteAsync]
    IAsyncOperation<VoiceCommandConfirmationResult> RequestConfirmationAsync(
      VoiceCommandResponse response);

    [RemoteAsync]
    IAsyncOperation<VoiceCommandDisambiguationResult> RequestDisambiguationAsync(
      VoiceCommandResponse response);

    [RemoteAsync]
    IAsyncAction ReportProgressAsync(VoiceCommandResponse response);

    [RemoteAsync]
    IAsyncAction ReportSuccessAsync(VoiceCommandResponse response);

    [RemoteAsync]
    IAsyncAction ReportFailureAsync(VoiceCommandResponse response);

    [RemoteAsync]
    IAsyncAction RequestAppLaunchAsync(VoiceCommandResponse response);

    Language Language { get; }

    event TypedEventHandler<VoiceCommandServiceConnection, VoiceCommandCompletedEventArgs> VoiceCommandCompleted;
  }
}
