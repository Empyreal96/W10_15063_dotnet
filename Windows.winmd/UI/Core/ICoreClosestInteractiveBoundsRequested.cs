// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreClosestInteractiveBoundsRequested
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [Guid(4077061178, 59583, 20110, 174, 105, 201, 218, 221, 87, 161, 20)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (CoreComponentInputSource))]
  [WebHostHidden]
  internal interface ICoreClosestInteractiveBoundsRequested
  {
    event TypedEventHandler<CoreComponentInputSource, ClosestInteractiveBoundsRequestedEventArgs> ClosestInteractiveBoundsRequested;
  }
}
