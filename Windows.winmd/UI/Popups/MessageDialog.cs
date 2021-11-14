// Decompiled with JetBrains decompiler
// Type: Windows.UI.Popups.MessageDialog
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Popups
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Standard)]
  [Activatable(typeof (IMessageDialogFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [Muse(Version = 100794368)]
  public sealed class MessageDialog : IMessageDialog
  {
    [MethodImpl]
    public extern MessageDialog(string content);

    [MethodImpl]
    public extern MessageDialog(string content, string title);

    public extern string Title { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<IUICommand> Commands { [MethodImpl] get; }

    public extern uint DefaultCommandIndex { [MethodImpl] get; [MethodImpl] set; }

    public extern uint CancelCommandIndex { [MethodImpl] get; [MethodImpl] set; }

    public extern string Content { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern IAsyncOperation<IUICommand> ShowAsync();

    public extern MessageDialogOptions Options { [MethodImpl] get; [MethodImpl] set; }
  }
}
