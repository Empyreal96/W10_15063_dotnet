﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IToggleMenuFlyoutItem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ToggleMenuFlyoutItem))]
  [Guid(1233395421, 35049, 18019, 167, 1, 205, 79, 210, 94, 57, 143)]
  [WebHostHidden]
  internal interface IToggleMenuFlyoutItem
  {
    bool IsChecked { get; set; }
  }
}
