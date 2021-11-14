// Decompiled with JetBrains decompiler
// Type: Windows.Storage.AccessCache.AccessCacheOptions
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage.AccessCache
{
  [Flags]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum AccessCacheOptions : uint
  {
    None = 0,
    DisallowUserInput = 1,
    FastLocationsOnly = 2,
    UseReadOnlyCachedCopy = 4,
    SuppressAccessTimeUpdate = 8,
  }
}
