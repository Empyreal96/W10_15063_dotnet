﻿// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.IMapElementModel
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;

namespace Microsoft.Phone.Maps.Controls
{
  internal interface IMapElementModel
  {
    ulong ZIndex { get; set; }

    bool Visible { get; set; }

    IntPtr Handle { get; }

    object Backend { get; }
  }
}
