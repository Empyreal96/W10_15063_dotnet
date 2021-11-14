// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.IPointerPointProperties2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input
{
  [Guid(583222074, 51259, 16832, 162, 150, 94, 35, 45, 100, 214, 175)]
  [ExclusiveTo(typeof (PointerPointProperties))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IPointerPointProperties2
  {
    IReference<float> ZDistance { get; }
  }
}
