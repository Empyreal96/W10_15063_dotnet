// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.VoiceCommands.IVoiceCommandCompletedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.VoiceCommands
{
  [Guid(3361630045, 65090, 17196, 153, 7, 9, 223, 159, 207, 100, 232)]
  [ExclusiveTo(typeof (VoiceCommandCompletedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IVoiceCommandCompletedEventArgs
  {
    VoiceCommandCompletionReason Reason { get; }
  }
}
