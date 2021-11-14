// Decompiled with JetBrains decompiler
// Type: Windows.Perception.IPerceptionTimestampHelperStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception
{
  [Guid(1202065876, 43487, 20188, 133, 93, 244, 211, 57, 217, 103, 172)]
  [ExclusiveTo(typeof (PerceptionTimestampHelper))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  internal interface IPerceptionTimestampHelperStatics
  {
    PerceptionTimestamp FromHistoricalTargetTime(DateTime targetTime);
  }
}
