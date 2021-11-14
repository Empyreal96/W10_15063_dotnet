// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.ITranslateTransform
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (TranslateTransform))]
  [Guid(3379925084, 15414, 16937, 129, 123, 23, 143, 100, 192, 225, 19)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface ITranslateTransform
  {
    double X { get; set; }

    double Y { get; set; }
  }
}
