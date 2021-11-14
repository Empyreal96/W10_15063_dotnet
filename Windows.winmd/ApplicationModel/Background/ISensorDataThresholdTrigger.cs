// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ISensorDataThresholdTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (SensorDataThresholdTrigger))]
  [Guid(1539371890, 54411, 19327, 171, 236, 21, 249, 186, 204, 18, 226)]
  internal interface ISensorDataThresholdTrigger : IBackgroundTrigger
  {
  }
}
