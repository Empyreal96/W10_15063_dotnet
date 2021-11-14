// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.Printing3D.IPrint3DManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.Printing3D
{
  [ExclusiveTo(typeof (Print3DManager))]
  [Guid(1294977802, 29542, 18801, 139, 213, 23, 196, 227, 232, 198, 192)]
  [ContractVersion(typeof (Printing3DContract), 65536)]
  internal interface IPrint3DManager
  {
    event TypedEventHandler<Print3DManager, Print3DTaskRequestedEventArgs> TaskRequested;
  }
}
