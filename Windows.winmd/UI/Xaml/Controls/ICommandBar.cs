// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICommandBar
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (CommandBar))]
  [Guid(2562474624, 19005, 19694, 189, 7, 34, 206, 148, 197, 175, 118)]
  internal interface ICommandBar
  {
    IObservableVector<ICommandBarElement> PrimaryCommands { get; }

    IObservableVector<ICommandBarElement> SecondaryCommands { get; }
  }
}
