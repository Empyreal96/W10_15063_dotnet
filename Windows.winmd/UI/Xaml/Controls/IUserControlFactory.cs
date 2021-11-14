// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IUserControlFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UserControl))]
  [WebHostHidden]
  [Guid(951184786, 41610, 18802, 147, 223, 244, 247, 89, 184, 175, 210)]
  internal interface IUserControlFactory
  {
    UserControl CreateInstance(object outer, out object inner);
  }
}
