// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ForceFeedback.IConditionForceEffectFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.ForceFeedback
{
  [Guid(2443809380, 6160, 20150, 167, 115, 191, 211, 184, 205, 219, 171)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (ConditionForceEffect))]
  internal interface IConditionForceEffectFactory
  {
    ConditionForceEffect CreateInstance(ConditionForceEffectKind effectKind);
  }
}
