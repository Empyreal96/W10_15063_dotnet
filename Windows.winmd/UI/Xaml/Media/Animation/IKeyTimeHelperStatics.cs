// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IKeyTimeHelperStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [ExclusiveTo(typeof (KeyTimeHelper))]
  [Guid(2141348140, 8873, 17897, 154, 247, 199, 65, 110, 255, 247, 165)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IKeyTimeHelperStatics
  {
    KeyTime FromTimeSpan(TimeSpan timeSpan);
  }
}
