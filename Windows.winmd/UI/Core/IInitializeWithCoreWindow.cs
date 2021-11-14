// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.IInitializeWithCoreWindow
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [Guid(412033238, 39027, 17994, 172, 229, 87, 224, 16, 244, 101, 230)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  public interface IInitializeWithCoreWindow
  {
    void Initialize(CoreWindow window);
  }
}
