// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Markup.IDataTemplateComponent
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Markup
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(138583496, 35504, 18247, 170, 154, 254, 173, 252, 141, 168, 225)]
  public interface IDataTemplateComponent
  {
    void Recycle();

    void ProcessBindings(object item, int itemIndex, int phase, out int nextPhase);
  }
}
