﻿// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.ITimedMetadataTrackFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2379576849, 38835, 19999, 133, 44, 15, 72, 44, 129, 173, 38)]
  [ExclusiveTo(typeof (TimedMetadataTrack))]
  internal interface ITimedMetadataTrackFactory
  {
    TimedMetadataTrack Create(string id, string language, TimedMetadataKind kind);
  }
}
