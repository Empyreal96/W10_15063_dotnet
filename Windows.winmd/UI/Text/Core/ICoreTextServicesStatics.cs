// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.ICoreTextServicesStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CoreTextServicesConstants))]
  [Guid(2441452102, 60623, 18340, 138, 231, 9, 138, 156, 111, 187, 21)]
  internal interface ICoreTextServicesStatics
  {
    char HiddenCharacter { get; }
  }
}
