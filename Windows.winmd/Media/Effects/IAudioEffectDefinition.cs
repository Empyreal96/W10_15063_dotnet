// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IAudioEffectDefinition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3839359348, 32128, 20339, 144, 137, 227, 28, 157, 185, 194, 148)]
  public interface IAudioEffectDefinition
  {
    string ActivatableClassId { get; }

    IPropertySet Properties { get; }
  }
}
