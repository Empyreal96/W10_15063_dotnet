// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.ISecondaryTile2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3002518581, 12880, 18832, 146, 60, 41, 74, 180, 182, 148, 221)]
  [ExclusiveTo(typeof (SecondaryTile))]
  internal interface ISecondaryTile2 : ISecondaryTile
  {
    string PhoneticName { set; get; }

    SecondaryTileVisualElements VisualElements { get; }

    bool RoamingEnabled { set; get; }

    event TypedEventHandler<SecondaryTile, VisualElementsRequestedEventArgs> VisualElementsRequested;
  }
}
