// Decompiled with JetBrains decompiler
// Type: Windows.System.LauncherOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Search;
using Windows.UI.ViewManagement;

namespace Windows.System
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class LauncherOptions : 
    ILauncherOptions,
    ILauncherViewOptions,
    ILauncherOptions2,
    ILauncherOptions3,
    ILauncherOptions4
  {
    [MethodImpl]
    public extern LauncherOptions();

    public extern bool TreatAsUntrusted { [MethodImpl] get; [MethodImpl] set; }

    public extern bool DisplayApplicationPicker { [MethodImpl] get; [MethodImpl] set; }

    public extern LauncherUIOptions UI { [MethodImpl] get; }

    public extern string PreferredApplicationPackageFamilyName { [MethodImpl] get; [MethodImpl] set; }

    public extern string PreferredApplicationDisplayName { [MethodImpl] get; [MethodImpl] set; }

    public extern Uri FallbackUri { [MethodImpl] get; [MethodImpl] set; }

    public extern string ContentType { [MethodImpl] get; [MethodImpl] set; }

    public extern ViewSizePreference DesiredRemainingView { [MethodImpl] get; [MethodImpl] set; }

    public extern string TargetApplicationPackageFamilyName { [MethodImpl] get; [MethodImpl] set; }

    public extern StorageFileQueryResult NeighboringFilesQuery { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IgnoreAppUriHandlers { [MethodImpl] get; [MethodImpl] set; }

    public extern bool LimitPickerToCurrentAppAndAppUriHandlers { [MethodImpl] get; [MethodImpl] set; }
  }
}
