// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IFontFamilyFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(3579851639, 15790, 19917, 175, 9, 249, 73, 142, 158, 198, 89)]
  [ExclusiveTo(typeof (FontFamily))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFontFamilyFactory
  {
    FontFamily CreateInstanceWithName(string familyName, object outer, out object inner);
  }
}
