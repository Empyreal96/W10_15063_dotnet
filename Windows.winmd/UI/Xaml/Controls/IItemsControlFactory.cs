﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IItemsControlFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4156277593, 63741, 18204, 188, 178, 44, 116, 190, 142, 191, 140)]
  [ExclusiveTo(typeof (ItemsControl))]
  [WebHostHidden]
  internal interface IItemsControlFactory
  {
    ItemsControl CreateInstance(object outer, out object inner);
  }
}
