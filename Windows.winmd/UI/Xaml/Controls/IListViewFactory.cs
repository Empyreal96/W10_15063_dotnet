﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListViewFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ListView))]
  [Guid(3187632493, 16162, 16889, 151, 166, 136, 49, 52, 167, 97, 19)]
  [WebHostHidden]
  internal interface IListViewFactory
  {
    ListView CreateInstance(object outer, out object inner);
  }
}
