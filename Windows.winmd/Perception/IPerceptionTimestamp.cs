// Decompiled with JetBrains decompiler
// Type: Windows.Perception.IPerceptionTimestamp
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception
{
  [ExclusiveTo(typeof (PerceptionTimestamp))]
  [Guid(2277656580, 41518, 19163, 186, 38, 215, 142, 246, 57, 188, 244)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IPerceptionTimestamp
  {
    DateTime TargetTime { get; }

    TimeSpan PredictionAmount { get; }
  }
}
