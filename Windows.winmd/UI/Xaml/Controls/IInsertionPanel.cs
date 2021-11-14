// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IInsertionPanel
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1804460175, 25895, 19769, 188, 191, 88, 176, 29, 169, 35, 215)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public interface IInsertionPanel
  {
    void GetInsertionIndexes(Point position, out int first, out int second);
  }
}
