﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.LineSegment
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Static(typeof (ILineSegmentStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public sealed class LineSegment : PathSegment, ILineSegment
  {
    [MethodImpl]
    public extern LineSegment();

    public extern Point Point { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty PointProperty { [MethodImpl] get; }
  }
}