// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.PlatformDiagnosticsAndUsageDataSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Profile
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Static(typeof (IPlatformDiagnosticsAndUsageDataSettingsStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  public static class PlatformDiagnosticsAndUsageDataSettings
  {
    public static extern PlatformDataCollectionLevel CollectionLevel { [MethodImpl] get; }

    public static extern event EventHandler<object> CollectionLevelChanged;

    [MethodImpl]
    public static extern bool CanCollectDiagnostics(PlatformDataCollectionLevel level);
  }
}
