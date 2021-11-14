// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IVideoEffectDefinition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(972262640, 36111, 20286, 132, 252, 45, 70, 165, 41, 121, 67)]
  public interface IVideoEffectDefinition
  {
    string ActivatableClassId { get; }

    IPropertySet Properties { get; }
  }
}
