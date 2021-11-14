// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.IDiagnosticsSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.UserProfile
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (DiagnosticsSettings))]
  [Guid(3857312973, 10001, 17632, 151, 60, 73, 29, 120, 4, 141, 36)]
  internal interface IDiagnosticsSettings
  {
    bool CanUseDiagnosticsToTailorExperiences { get; }

    User User { get; }
  }
}
