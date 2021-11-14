// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.IDiagnosticsSettingsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.UserProfile
{
  [ExclusiveTo(typeof (DiagnosticsSettings))]
  [Guid(1926424591, 21392, 18323, 153, 11, 60, 204, 125, 106, 201, 200)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IDiagnosticsSettingsStatics
  {
    DiagnosticsSettings GetDefault();

    DiagnosticsSettings GetForUser(User user);
  }
}
