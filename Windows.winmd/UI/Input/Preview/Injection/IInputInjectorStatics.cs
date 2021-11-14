// Decompiled with JetBrains decompiler
// Type: Windows.UI.Input.Preview.Injection.IInputInjectorStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Input.Preview.Injection
{
  [Guid(3735972163, 29698, 16705, 165, 198, 12, 1, 170, 87, 177, 106)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (InputInjector))]
  internal interface IInputInjectorStatics
  {
    InputInjector TryCreate();
  }
}
