﻿// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.UIViewSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.ViewManagement
{
  [Static(typeof (IUIViewSettingsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class UIViewSettings : IUIViewSettings
  {
    public extern UserInteractionMode UserInteractionMode { [MethodImpl] get; }

    [MethodImpl]
    public static extern UIViewSettings GetForCurrentView();
  }
}
