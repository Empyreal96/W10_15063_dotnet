﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ISolidColorBrushFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (SolidColorBrush))]
  [Guid(3644182028, 34549, 19878, 138, 39, 177, 97, 158, 247, 249, 43)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface ISolidColorBrushFactory
  {
    SolidColorBrush CreateInstanceWithColor(Color color);
  }
}
