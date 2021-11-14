// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Automation.Provider.ISpreadsheetItemProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Automation.Provider
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3957231506, 24597, 18470, 183, 25, 71, 82, 26, 129, 198, 126)]
  public interface ISpreadsheetItemProvider
  {
    string Formula { get; }

    IRawElementProviderSimple[] GetAnnotationObjects();

    AnnotationType[] GetAnnotationTypes();
  }
}
