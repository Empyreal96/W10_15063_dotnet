// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Networking.NetworkOperators.IPhoneCallAnnotationEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Phone.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (PhoneCallAnnotationEventArgs))]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  [Guid(3871259509, 23192, 18157, 161, 242, 237, 228, 23, 98, 150, 50)]
  internal interface IPhoneCallAnnotationEventArgs
  {
    string PhoneNumber { get; }

    string Location { get; set; }
  }
}
