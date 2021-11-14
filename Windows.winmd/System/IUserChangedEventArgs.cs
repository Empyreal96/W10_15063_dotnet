// Decompiled with JetBrains decompiler
// Type: Windows.System.IUserChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [Guid(140794332, 6342, 18651, 188, 153, 114, 79, 185, 32, 60, 204)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (UserChangedEventArgs))]
  internal interface IUserChangedEventArgs
  {
    User User { get; }
  }
}
