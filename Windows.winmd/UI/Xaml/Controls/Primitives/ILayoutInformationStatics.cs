﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.Primitives.ILayoutInformationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls.Primitives
{
  [WebHostHidden]
  [ExclusiveTo(typeof (LayoutInformation))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3473330073, 22761, 18050, 131, 38, 80, 202, 171, 101, 237, 124)]
  internal interface ILayoutInformationStatics
  {
    UIElement GetLayoutExceptionElement(object dispatcher);

    Rect GetLayoutSlot(FrameworkElement element);
  }
}
