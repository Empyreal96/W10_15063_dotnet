// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.Animation.IObjectKeyFrame
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media.Animation
{
  [Guid(2555553873, 34195, 18670, 166, 164, 213, 212, 114, 15, 2, 154)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ObjectKeyFrame))]
  internal interface IObjectKeyFrame
  {
    object Value { get; set; }

    KeyTime KeyTime { get; set; }
  }
}
