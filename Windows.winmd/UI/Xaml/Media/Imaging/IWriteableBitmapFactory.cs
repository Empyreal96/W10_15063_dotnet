﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Imaging.IWriteableBitmapFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Imaging
{
  [WebHostHidden]
  [Guid(1432611761, 16114, 17093, 156, 109, 28, 245, 220, 192, 65, 255)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (WriteableBitmap))]
  internal interface IWriteableBitmapFactory
  {
    WriteableBitmap CreateInstanceWithDimensions(int pixelWidth, int pixelHeight);
  }
}
