﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Peers.ITimePickerAutomationPeerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls;

namespace Windows.UI.Xaml.Automation.Peers
{
  [Guid(2542757489, 18424, 16551, 158, 33, 104, 18, 139, 22, 180, 253)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TimePickerAutomationPeer))]
  [WebHostHidden]
  internal interface ITimePickerAutomationPeerFactory
  {
    TimePickerAutomationPeer CreateInstanceWithOwner(
      TimePicker owner,
      object outer,
      out object inner);
  }
}
