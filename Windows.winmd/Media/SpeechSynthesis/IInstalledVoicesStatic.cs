// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechSynthesis.IInstalledVoicesStatic
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechSynthesis
{
  [ExclusiveTo(typeof (SpeechSynthesizer))]
  [Guid(2102554316, 30003, 19519, 133, 190, 136, 140, 43, 174, 235, 220)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IInstalledVoicesStatic
  {
    IVectorView<VoiceInformation> AllVoices { get; }

    VoiceInformation DefaultVoice { get; }
  }
}
