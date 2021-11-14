// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.IVoiceCommandServiceConnectionStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.AppService;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.VoiceCommands
{
  [ExclusiveTo(typeof (VoiceCommandServiceConnection))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(923713531, 11572, 17119, 135, 112, 7, 77, 15, 51, 70, 151)]
  internal interface IVoiceCommandServiceConnectionStatics
  {
    VoiceCommandServiceConnection FromAppServiceTriggerDetails(
      AppServiceTriggerDetails triggerDetails);
  }
}
