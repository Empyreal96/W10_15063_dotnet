// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.IJumpListItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [Guid(2061199127, 35677, 18464, 153, 91, 155, 65, 141, 190, 72, 176)]
  [ExclusiveTo(typeof (JumpListItem))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IJumpListItem
  {
    JumpListItemKind Kind { get; }

    string Arguments { get; }

    bool RemovedByUser { get; }

    string Description { get; set; }

    string DisplayName { get; set; }

    string GroupName { get; set; }

    Uri Logo { get; set; }
  }
}
