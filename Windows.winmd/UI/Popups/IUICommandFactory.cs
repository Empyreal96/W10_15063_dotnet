// Decompiled with JetBrains decompiler
// Type: Windows.UI.Popups.IUICommandFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Popups
{
  [ExclusiveTo(typeof (UICommand))]
  [Guid(2719646089, 9904, 18038, 174, 148, 84, 4, 27, 193, 37, 232)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IUICommandFactory
  {
    UICommand Create(string label);

    UICommand CreateWithHandler(string label, UICommandInvokedHandler action);

    UICommand CreateWithHandlerAndId(
      string label,
      UICommandInvokedHandler action,
      [Variant] object commandId);
  }
}
