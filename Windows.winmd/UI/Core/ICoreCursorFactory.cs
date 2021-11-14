// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreCursorFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [Guid(4130706977, 42909, 20179, 140, 50, 169, 239, 157, 107, 118, 164)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CoreCursor))]
  [WebHostHidden]
  internal interface ICoreCursorFactory
  {
    CoreCursor CreateCursor(CoreCursorType type, uint id);
  }
}
