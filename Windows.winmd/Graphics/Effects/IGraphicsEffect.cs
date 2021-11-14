// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Effects.IGraphicsEffect
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Effects
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(3411132622, 36838, 17974, 178, 2, 134, 31, 170, 7, 216, 243)]
  public interface IGraphicsEffect : IGraphicsEffectSource
  {
    string Name { get; set; }
  }
}
