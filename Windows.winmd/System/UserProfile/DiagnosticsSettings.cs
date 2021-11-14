// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.DiagnosticsSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.UserProfile
{
  [DualApiPartition(version = 167772163)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IDiagnosticsSettingsStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Threading(ThreadingModel.Both)]
  public sealed class DiagnosticsSettings : IDiagnosticsSettings
  {
    public extern bool CanUseDiagnosticsToTailorExperiences { [MethodImpl] get; }

    public extern User User { [MethodImpl] get; }

    [MethodImpl]
    public static extern DiagnosticsSettings GetDefault();

    [MethodImpl]
    public static extern DiagnosticsSettings GetForUser(User user);
  }
}
