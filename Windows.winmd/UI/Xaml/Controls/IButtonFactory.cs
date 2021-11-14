// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IButtonFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [WebHostHidden]
  [ExclusiveTo(typeof (Button))]
  [Guid(2158050329, 33850, 17692, 140, 245, 68, 199, 1, 176, 226, 22)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IButtonFactory
  {
    Button CreateInstance(object outer, out object inner);
  }
}
