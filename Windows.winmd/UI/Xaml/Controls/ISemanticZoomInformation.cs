// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ISemanticZoomInformation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(2808757091, 8859, 19909, 170, 17, 157, 146, 47, 191, 138, 152)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public interface ISemanticZoomInformation
  {
    SemanticZoom SemanticZoomOwner { get; set; }

    bool IsActiveView { get; set; }

    bool IsZoomedInView { get; set; }

    void InitializeViewChange();

    void CompleteViewChange();

    void MakeVisible(SemanticZoomLocation item);

    void StartViewChangeFrom(SemanticZoomLocation source, SemanticZoomLocation destination);

    void StartViewChangeTo(SemanticZoomLocation source, SemanticZoomLocation destination);

    void CompleteViewChangeFrom(SemanticZoomLocation source, SemanticZoomLocation destination);

    void CompleteViewChangeTo(SemanticZoomLocation source, SemanticZoomLocation destination);
  }
}
