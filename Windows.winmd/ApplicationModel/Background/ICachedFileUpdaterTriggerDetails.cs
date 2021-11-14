// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ICachedFileUpdaterTriggerDetails
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Provider;

namespace Windows.ApplicationModel.Background
{
  [Guid(1904446483, 4884, 18356, 149, 151, 220, 126, 36, 140, 23, 204)]
  [ExclusiveTo(typeof (CachedFileUpdaterTriggerDetails))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICachedFileUpdaterTriggerDetails
  {
    CachedFileTarget UpdateTarget { get; }

    FileUpdateRequest UpdateRequest { get; }

    bool CanRequestUserInput { get; }
  }
}
