// Decompiled with JetBrains decompiler
// Type: Windows.System.UserProfile.IFirstSignInSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.UserProfile
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (FirstSignInSettings))]
  [Guid(1049907539, 14942, 17710, 166, 1, 245, 186, 173, 42, 72, 112)]
  internal interface IFirstSignInSettings : 
    IMapView<string, object>,
    IIterable<IKeyValuePair<string, object>>
  {
  }
}
