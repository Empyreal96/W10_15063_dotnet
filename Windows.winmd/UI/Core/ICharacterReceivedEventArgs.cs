// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICharacterReceivedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [Guid(3313788319, 39346, 19404, 189, 51, 4, 230, 63, 66, 144, 46)]
  [ExclusiveTo(typeof (CharacterReceivedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface ICharacterReceivedEventArgs : ICoreWindowEventArgs
  {
    uint KeyCode { get; }

    CorePhysicalKeyStatus KeyStatus { get; }
  }
}
