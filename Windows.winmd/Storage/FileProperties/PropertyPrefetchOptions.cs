﻿// Decompiled with JetBrains decompiler
// Type: Windows.Storage.FileProperties.PropertyPrefetchOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.FileProperties
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum PropertyPrefetchOptions : uint
  {
    None = 0,
    MusicProperties = 1,
    VideoProperties = 2,
    ImageProperties = 4,
    DocumentProperties = 8,
    BasicProperties = 16, // 0x00000010
  }
}
