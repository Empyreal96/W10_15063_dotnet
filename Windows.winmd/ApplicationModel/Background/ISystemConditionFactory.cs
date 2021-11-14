// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ISystemConditionFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ExclusiveTo(typeof (SystemCondition))]
  [Guid(3530150385, 1447, 18862, 135, 215, 22, 178, 184, 185, 165, 83)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISystemConditionFactory
  {
    SystemCondition Create(SystemConditionType conditionType);
  }
}
