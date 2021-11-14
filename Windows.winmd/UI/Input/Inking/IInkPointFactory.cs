// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Inking.IInkPointFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Inking
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(702928156, 51599, 16477, 159, 59, 229, 62, 49, 6, 141, 77)]
  public interface IInkPointFactory
  {
    InkPoint CreateInkPoint(Point position, float pressure);
  }
}
