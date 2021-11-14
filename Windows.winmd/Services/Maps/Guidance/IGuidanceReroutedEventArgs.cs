// Decompiled with JetBrains decompiler
// Type: Windows.Services.Maps.Guidance.IGuidanceReroutedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Services.Maps.Guidance
{
  [ExclusiveTo(typeof (GuidanceReroutedEventArgs))]
  [Guid(291323912, 54568, 17742, 187, 148, 165, 3, 65, 210, 201, 241)]
  [WebHostHidden]
  [ContractVersion(typeof (GuidanceContract), 65536)]
  internal interface IGuidanceReroutedEventArgs
  {
    GuidanceRoute Route { get; }
  }
}
