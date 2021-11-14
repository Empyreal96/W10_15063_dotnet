// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionEffectFactoryLoadStatus
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  public enum CompositionEffectFactoryLoadStatus
  {
    Other = -1, // 0xFFFFFFFF
    Success = 0,
    EffectTooComplex = 1,
    Pending = 2,
  }
}
