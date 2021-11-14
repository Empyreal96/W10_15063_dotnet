// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ISystemCondition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (SystemCondition))]
  [Guid(3244274806, 35269, 16907, 171, 211, 251, 48, 48, 71, 33, 40)]
  internal interface ISystemCondition : IBackgroundCondition
  {
    SystemConditionType ConditionType { get; }
  }
}
