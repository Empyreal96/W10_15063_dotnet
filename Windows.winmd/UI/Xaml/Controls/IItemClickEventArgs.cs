﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemClickEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2620473922, 62106, 18765, 163, 165, 212, 199, 178, 164, 104, 82)]
  [ExclusiveTo(typeof (ItemClickEventArgs))]
  internal interface IItemClickEventArgs
  {
    object ClickedItem { get; }
  }
}
