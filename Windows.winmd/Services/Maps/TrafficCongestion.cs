// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.TrafficCongestion
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Maps
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  public enum TrafficCongestion
  {
    Unknown,
    Light,
    Mild,
    Medium,
    Heavy,
  }
}
