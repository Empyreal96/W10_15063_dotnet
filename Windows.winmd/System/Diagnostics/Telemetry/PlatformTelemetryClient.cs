﻿// Decompiled with JetBrains decompiler
// Type: Windows.System.Diagnostics.Telemetry.PlatformTelemetryClient
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.Diagnostics.Telemetry
{
  [Static(typeof (IPlatformTelemetryClientStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [DualApiPartition(version = 167772163)]
  public static class PlatformTelemetryClient
  {
    [Overload("Register")]
    [MethodImpl]
    public static extern PlatformTelemetryRegistrationResult Register(
      string id);

    [Overload("RegisterWithSettings")]
    [MethodImpl]
    public static extern PlatformTelemetryRegistrationResult Register(
      string id,
      PlatformTelemetryRegistrationSettings settings);
  }
}