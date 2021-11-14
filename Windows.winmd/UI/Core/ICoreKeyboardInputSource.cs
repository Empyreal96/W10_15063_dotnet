// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreKeyboardInputSource
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

namespace Windows.UI.Core
{
  [Guid(589074568, 58473, 19953, 178, 8, 110, 73, 13, 113, 203, 144)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CoreComponentInputSource))]
  internal interface ICoreKeyboardInputSource
  {
    CoreVirtualKeyStates GetCurrentKeyState(VirtualKey virtualKey);

    event TypedEventHandler<object, CharacterReceivedEventArgs> CharacterReceived;

    event TypedEventHandler<object, KeyEventArgs> KeyDown;

    event TypedEventHandler<object, KeyEventArgs> KeyUp;
  }
}
