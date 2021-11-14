// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Core.IFrameworkView
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.ApplicationModel.Core
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4205534416, 35108, 17836, 173, 15, 160, 143, 174, 93, 3, 36)]
  public interface IFrameworkView
  {
    void Initialize(CoreApplicationView applicationView);

    void SetWindow(CoreWindow window);

    void Load(string entryPoint);

    void Run();

    void Uninitialize();
  }
}
