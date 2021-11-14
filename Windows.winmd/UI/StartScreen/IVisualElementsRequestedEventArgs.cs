// Decompiled with JetBrains decompiler
// Type: Windows.UI.StartScreen.IVisualElementsRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.StartScreen
{
  [ExclusiveTo(typeof (VisualElementsRequestedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2070923650, 14861, 20174, 175, 150, 205, 23, 225, 176, 11, 45)]
  internal interface IVisualElementsRequestedEventArgs
  {
    VisualElementsRequest Request { get; }
  }
}
