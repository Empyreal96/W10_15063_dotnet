// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.ICheckBoxFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CheckBox))]
  [WebHostHidden]
  [Guid(1336322747, 16203, 17153, 190, 7, 17, 114, 234, 97, 238, 251)]
  internal interface ICheckBoxFactory
  {
    CheckBox CreateInstance(object outer, out object inner);
  }
}
