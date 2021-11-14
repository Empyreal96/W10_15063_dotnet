// Decompiled with JetBrains decompiler
// Type: Windows.UI.Popups.IMessageDialog
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Popups
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (MessageDialog))]
  [Guid(871734017, 21285, 17323, 154, 179, 189, 174, 68, 14, 65, 33)]
  internal interface IMessageDialog
  {
    string Title { get; set; }

    IVector<IUICommand> Commands { get; }

    uint DefaultCommandIndex { get; set; }

    uint CancelCommandIndex { get; set; }

    string Content { get; set; }

    IAsyncOperation<IUICommand> ShowAsync();

    MessageDialogOptions Options { get; set; }
  }
}
