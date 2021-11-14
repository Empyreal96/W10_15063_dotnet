// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.ICustomGameControllerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  [WebHostHidden]
  [Guid(1772138078, 30094, 19646, 172, 230, 98, 21, 95, 233, 18, 111)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  public interface ICustomGameControllerFactory
  {
    object CreateGameController(IGameControllerProvider provider);

    void OnGameControllerAdded(IGameController value);

    void OnGameControllerRemoved(IGameController value);
  }
}
