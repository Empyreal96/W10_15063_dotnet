// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IRadioButtonFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (RadioButton))]
  [Guid(4056959283, 13537, 19036, 178, 174, 202, 59, 28, 11, 32, 222)]
  internal interface IRadioButtonFactory
  {
    RadioButton CreateInstance(object outer, out object inner);
  }
}
