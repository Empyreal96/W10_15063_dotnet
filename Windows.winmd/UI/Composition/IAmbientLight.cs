// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.IAmbientLight
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Composition
{
  [ExclusiveTo(typeof (AmbientLight))]
  [WebHostHidden]
  [Guid(2759930017, 47044, 18167, 185, 191, 218, 244, 58, 68, 230, 238)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IAmbientLight
  {
    Color Color { get; set; }
  }
}
