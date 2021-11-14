// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.Synthesis.IInstalledVoicesStatic
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.Synthesis
{
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [ExclusiveTo(typeof (InstalledVoices))]
  [Guid(4052740763, 34443, 18098, 153, 85, 79, 249, 35, 232, 91, 251)]
  internal interface IInstalledVoicesStatic
  {
    IVectorView<VoiceInformation> All { get; }

    VoiceInformation Default { get; }
  }
}
