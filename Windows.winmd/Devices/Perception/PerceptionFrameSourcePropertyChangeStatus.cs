﻿// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Perception.PerceptionFrameSourcePropertyChangeStatus
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Perception
{
  [Deprecated("PerceptionFrameSourcePropertyChangeStatus may be unavailable after Windows Creator Update.  Please refer to Windows.Media.Capture.Frames APIs on MSDN.", DeprecationType.Deprecate, 262144, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum PerceptionFrameSourcePropertyChangeStatus
  {
    Unknown,
    Accepted,
    LostControl,
    PropertyNotSupported,
    PropertyReadOnly,
    ValueOutOfRange,
  }
}
