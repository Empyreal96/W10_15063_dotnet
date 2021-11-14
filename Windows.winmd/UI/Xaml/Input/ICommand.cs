// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Input.ICommand
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Input
{
  [WebHostHidden]
  [Guid(3853464898, 51815, 16513, 153, 91, 112, 157, 209, 55, 146, 223)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public interface ICommand
  {
    event EventHandler<object> CanExecuteChanged;

    bool CanExecute(object parameter);

    void Execute(object parameter);
  }
}
