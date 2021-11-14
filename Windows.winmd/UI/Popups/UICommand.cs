// Decompiled with JetBrains decompiler
// Type: Windows.UI.Popups.UICommand
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Popups
{
  [Muse(Version = 100794368)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [Activatable(typeof (IUICommandFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class UICommand : IUICommand
  {
    [MethodImpl]
    public extern UICommand(string label);

    [MethodImpl]
    public extern UICommand(string label, UICommandInvokedHandler action);

    [MethodImpl]
    public extern UICommand(string label, UICommandInvokedHandler action, [Variant] object commandId);

    [MethodImpl]
    public extern UICommand();

    public extern string Label { [MethodImpl] get; [MethodImpl] set; }

    public extern UICommandInvokedHandler Invoked { [MethodImpl] get; [MethodImpl] set; }

    public extern object Id { [MethodImpl] [return: Variant] get; [MethodImpl] [param: Variant] set; }
  }
}
