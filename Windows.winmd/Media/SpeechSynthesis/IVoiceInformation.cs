// Decompiled with JetBrains decompiler
// Type: Windows.Media.SpeechSynthesis.IVoiceInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.SpeechSynthesis
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2972178084, 4753, 17924, 170, 156, 131, 19, 64, 131, 53, 44)]
  [ExclusiveTo(typeof (VoiceInformation))]
  internal interface IVoiceInformation
  {
    string DisplayName { get; }

    string Id { get; }

    string Language { get; }

    string Description { get; }

    VoiceGender Gender { get; }
  }
}
