﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.SourceSuspensionChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;
using Windows.Phone;

namespace Windows.Media.Capture
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (PhoneContract), 65536)]
  public sealed class SourceSuspensionChangedEventArgs : ISourceSuspensionChangedEventArgs
  {
    public extern bool IsAudioSuspended { [MethodImpl] get; }

    public extern bool IsVideoSuspended { [MethodImpl] get; }
  }
}
