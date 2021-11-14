// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Speech.Synthesis.InstalledVoices
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Speech.Synthesis
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Static(typeof (IInstalledVoicesStatic), 65536, "Windows.Phone.PhoneInternalContract")]
  public static class InstalledVoices
  {
    public static extern IVectorView<VoiceInformation> All { [MethodImpl] get; }

    public static extern VoiceInformation Default { [MethodImpl] get; }
  }
}
