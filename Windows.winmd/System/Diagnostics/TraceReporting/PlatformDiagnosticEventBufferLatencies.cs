﻿// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticEventBufferLatencies
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.TraceReporting
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Flags]
  public enum PlatformDiagnosticEventBufferLatencies : uint
  {
    Normal = 1,
    CostDeferred = 2,
    Realtime = 4,
  }
}
