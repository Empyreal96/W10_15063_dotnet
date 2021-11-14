// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IGroupStyleFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (GroupStyle))]
  [Guid(1459578447, 58071, 20297, 128, 61, 199, 39, 205, 249, 55, 45)]
  internal interface IGroupStyleFactory
  {
    GroupStyle CreateInstance(object outer, out object inner);
  }
}
