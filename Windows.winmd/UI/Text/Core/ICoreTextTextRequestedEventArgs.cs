// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.ICoreTextTextRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(4036403920, 16838, 19458, 139, 26, 217, 83, 176, 12, 171, 179)]
  [ExclusiveTo(typeof (CoreTextTextRequestedEventArgs))]
  internal interface ICoreTextTextRequestedEventArgs
  {
    CoreTextTextRequest Request { get; }
  }
}
