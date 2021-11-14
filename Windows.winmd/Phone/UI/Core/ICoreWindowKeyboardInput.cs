// Decompiled with JetBrains decompiler
// Type: Windows.Phone.UI.Core.ICoreWindowKeyboardInput
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.UI.Core
{
  [WebHostHidden]
  [Guid(426448734, 6707, 19223, 153, 53, 51, 142, 246, 68, 52, 119)]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  public interface ICoreWindowKeyboardInput
  {
    bool IsKeyboardInputEnabled { get; set; }

    KeyboardInputBuffer KeyboardInputBuffer { get; set; }
  }
}
