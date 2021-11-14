// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.ForceFeedback.IPeriodicForceEffectFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.ForceFeedback
{
  [ExclusiveTo(typeof (PeriodicForceEffect))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(1868753690, 38993, 18299, 179, 24, 53, 236, 170, 21, 7, 15)]
  internal interface IPeriodicForceEffectFactory
  {
    PeriodicForceEffect CreateInstance(PeriodicForceEffectKind effectKind);
  }
}
