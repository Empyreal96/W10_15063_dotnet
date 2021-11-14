// Decompiled with JetBrains decompiler
// Type: Windows.Media.Effects.IVideoCompositorDefinition
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Effects
{
  [Guid(2034677968, 8208, 19171, 154, 178, 44, 239, 66, 237, 212, 210)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface IVideoCompositorDefinition
  {
    string ActivatableClassId { get; }

    IPropertySet Properties { get; }
  }
}
