// Decompiled with JetBrains decompiler
// Type: Windows.System.ILauncherOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3136954840, 45169, 19672, 133, 62, 52, 18, 3, 229, 87, 211)]
  [ExclusiveTo(typeof (LauncherOptions))]
  internal interface ILauncherOptions
  {
    bool TreatAsUntrusted { get; set; }

    bool DisplayApplicationPicker { get; set; }

    LauncherUIOptions UI { get; }

    string PreferredApplicationPackageFamilyName { get; set; }

    string PreferredApplicationDisplayName { get; set; }

    Uri FallbackUri { get; set; }

    string ContentType { get; set; }
  }
}
