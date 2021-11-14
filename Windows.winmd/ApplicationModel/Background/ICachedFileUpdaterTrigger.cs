// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Background.ICachedFileUpdaterTrigger
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Background
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CachedFileUpdaterTrigger))]
  [Guid(3793530603, 13042, 19761, 181, 83, 185, 224, 27, 222, 55, 224)]
  internal interface ICachedFileUpdaterTrigger : IBackgroundTrigger
  {
  }
}
