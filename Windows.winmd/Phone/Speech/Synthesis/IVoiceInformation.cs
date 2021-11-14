// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.Synthesis.IVoiceInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.Synthesis
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Guid(2244695844, 8089, 20186, 172, 143, 105, 71, 194, 9, 39, 179)]
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
