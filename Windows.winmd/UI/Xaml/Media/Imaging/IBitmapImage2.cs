﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.IBitmapImage2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (BitmapImage))]
  [Guid(275366326, 35995, 18274, 190, 61, 117, 159, 86, 152, 242, 179)]
  internal interface IBitmapImage2
  {
    DecodePixelType DecodePixelType { get; set; }
  }
}
