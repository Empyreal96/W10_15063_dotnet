﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IPolyLineSegment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (PolyLineSegment))]
  [Guid(1262059399, 41702, 18333, 189, 200, 111, 68, 100, 100, 104, 135)]
  internal interface IPolyLineSegment
  {
    PointCollection Points { get; set; }
  }
}
