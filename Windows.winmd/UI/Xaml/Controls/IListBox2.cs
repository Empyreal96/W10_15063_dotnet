// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IListBox2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [Guid(1884760762, 35537, 16517, 147, 80, 222, 238, 53, 146, 148, 227)]
  [ExclusiveTo(typeof (ListBox))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [WebHostHidden]
  internal interface IListBox2
  {
    bool SingleSelectionFollowsFocus { get; set; }
  }
}
