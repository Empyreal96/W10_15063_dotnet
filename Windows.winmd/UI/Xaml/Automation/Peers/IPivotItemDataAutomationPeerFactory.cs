﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.IPivotItemDataAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Peers
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1366959232, 54198, 16686, 130, 182, 148, 160, 168, 76, 19, 176)]
  [WebHostHidden]
  [ExclusiveTo(typeof (PivotItemDataAutomationPeer))]
  internal interface IPivotItemDataAutomationPeerFactory
  {
    PivotItemDataAutomationPeer CreateInstanceWithParentAndItem(
      object item,
      PivotAutomationPeer parent);
  }
}
