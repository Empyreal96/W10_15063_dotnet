// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.IVoiceCommandConfirmationResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.VoiceCommands
{
  [Guid(2686605630, 33313, 17702, 176, 131, 132, 9, 114, 38, 34, 71)]
  [ExclusiveTo(typeof (VoiceCommandConfirmationResult))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVoiceCommandConfirmationResult
  {
    bool Confirmed { get; }
  }
}
