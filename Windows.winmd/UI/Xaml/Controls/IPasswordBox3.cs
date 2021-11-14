// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IPasswordBox3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Input;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1613027793, 22199, 16880, 149, 88, 57, 52, 193, 66, 68, 214)]
  [ExclusiveTo(typeof (PasswordBox))]
  internal interface IPasswordBox3
  {
    PasswordRevealMode PasswordRevealMode { get; set; }

    TextReadingOrder TextReadingOrder { get; set; }

    InputScope InputScope { get; set; }
  }
}
