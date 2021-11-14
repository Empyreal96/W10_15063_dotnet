// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreTouchHitTesting
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [ExclusiveTo(typeof (CoreComponentInputSource))]
  [Guid(2983764617, 15055, 16676, 159, 163, 234, 138, 186, 53, 60, 33)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ICoreTouchHitTesting
  {
    event TypedEventHandler<object, TouchHitTestingEventArgs> TouchHitTesting;
  }
}
