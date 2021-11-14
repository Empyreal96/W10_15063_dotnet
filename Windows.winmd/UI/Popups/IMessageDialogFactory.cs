// Decompiled with JetBrains decompiler
// Type: Windows.UI.Popups.IMessageDialogFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Popups
{
  [ExclusiveTo(typeof (MessageDialog))]
  [Guid(756422519, 42607, 20133, 187, 135, 121, 63, 250, 73, 65, 242)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IMessageDialogFactory
  {
    MessageDialog Create(string content);

    MessageDialog CreateWithTitle(string content, string title);
  }
}
