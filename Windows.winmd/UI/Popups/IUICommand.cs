// Decompiled with JetBrains decompiler
// Type: Windows.UI.Popups.IUICommand
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Popups
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1341733493, 16709, 18431, 172, 127, 223, 241, 193, 250, 91, 15)]
  public interface IUICommand
  {
    string Label { get; set; }

    UICommandInvokedHandler Invoked { get; set; }

    object Id { [return: Variant] get; [param: Variant] set; }
  }
}
