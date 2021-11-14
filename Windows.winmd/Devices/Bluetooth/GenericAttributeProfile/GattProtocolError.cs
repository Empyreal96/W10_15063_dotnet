// Decompiled with JetBrains decompiler
// Type: Windows.Devices.Bluetooth.GenericAttributeProfile.GattProtocolError
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Devices.Bluetooth.GenericAttributeProfile
{
  [DualApiPartition(version = 167772163)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (IGattProtocolErrorStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public static class GattProtocolError
  {
    public static extern byte InvalidHandle { [MethodImpl] get; }

    public static extern byte ReadNotPermitted { [MethodImpl] get; }

    public static extern byte WriteNotPermitted { [MethodImpl] get; }

    public static extern byte InvalidPdu { [MethodImpl] get; }

    public static extern byte InsufficientAuthentication { [MethodImpl] get; }

    public static extern byte RequestNotSupported { [MethodImpl] get; }

    public static extern byte InvalidOffset { [MethodImpl] get; }

    public static extern byte InsufficientAuthorization { [MethodImpl] get; }

    public static extern byte PrepareQueueFull { [MethodImpl] get; }

    public static extern byte AttributeNotFound { [MethodImpl] get; }

    public static extern byte AttributeNotLong { [MethodImpl] get; }

    public static extern byte InsufficientEncryptionKeySize { [MethodImpl] get; }

    public static extern byte InvalidAttributeValueLength { [MethodImpl] get; }

    public static extern byte UnlikelyError { [MethodImpl] get; }

    public static extern byte InsufficientEncryption { [MethodImpl] get; }

    public static extern byte UnsupportedGroupType { [MethodImpl] get; }

    public static extern byte InsufficientResources { [MethodImpl] get; }
  }
}
