// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Controls.IHubFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Controls
{
  [ExclusiveTo(typeof (Hub))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3701912250, 50933, 18785, 153, 83, 197, 24, 115, 219, 84, 36)]
  internal interface IHubFactory
  {
    Hub CreateInstance(object outer, out object inner);
  }
}
