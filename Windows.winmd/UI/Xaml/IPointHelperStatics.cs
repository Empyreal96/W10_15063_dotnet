// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IPointHelperStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(22727285, 30424, 19326, 138, 51, 125, 121, 32, 70, 145, 238)]
  [ExclusiveTo(typeof (PointHelper))]
  [WebHostHidden]
  internal interface IPointHelperStatics
  {
    Point FromCoordinates(float x, float y);
  }
}
