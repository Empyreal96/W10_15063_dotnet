// Decompiled with JetBrains decompiler
// Type: Windows.Networking.Connectivity.RoamingStates
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.Connectivity
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Flags]
  public enum RoamingStates : uint
  {
    None = 0,
    NotRoaming = 1,
    Roaming = 2,
  }
}
