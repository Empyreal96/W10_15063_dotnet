// Decompiled with JetBrains decompiler
// Type: Windows.Services.TargetedContent.ITargetedContentItemState
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Services.TargetedContent
{
  [ContractVersion(typeof (TargetedContentContract), 65536)]
  [Guid(1939035220, 19557, 19271, 164, 65, 71, 45, 229, 60, 121, 182)]
  [ExclusiveTo(typeof (TargetedContentItemState))]
  internal interface ITargetedContentItemState
  {
    bool ShouldDisplay { get; }

    TargetedContentAppInstallationState AppInstallationState { get; }
  }
}
