// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.IPlatformDiagnosticsAndUsageDataSettingsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (PlatformDiagnosticsAndUsageDataSettings))]
  [Guid(3068283931, 31516, 19250, 140, 98, 166, 101, 151, 206, 114, 58)]
  internal interface IPlatformDiagnosticsAndUsageDataSettingsStatics
  {
    PlatformDataCollectionLevel CollectionLevel { get; }

    event EventHandler<object> CollectionLevelChanged;

    bool CanCollectDiagnostics(PlatformDataCollectionLevel level);
  }
}
