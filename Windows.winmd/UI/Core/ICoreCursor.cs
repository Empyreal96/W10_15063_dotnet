// Decompiled with JetBrains decompiler
// Type: Windows.UI.Core.ICoreCursor
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Core
{
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CoreCursor))]
  [Guid(2525575887, 4381, 17452, 138, 119, 184, 121, 146, 248, 226, 214)]
  internal interface ICoreCursor
  {
    uint Id { get; }

    CoreCursorType Type { get; }
  }
}
