// Decompiled with JetBrains decompiler
// Type: Windows.Graphics.DirectX.DirectXPixelFormat
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Graphics.DirectX
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public enum DirectXPixelFormat
  {
    Unknown = 0,
    R32G32B32A32Typeless = 1,
    R32G32B32A32Float = 2,
    R32G32B32A32UInt = 3,
    R32G32B32A32Int = 4,
    R32G32B32Typeless = 5,
    R32G32B32Float = 6,
    R32G32B32UInt = 7,
    R32G32B32Int = 8,
    R16G16B16A16Typeless = 9,
    R16G16B16A16Float = 10, // 0x0000000A
    R16G16B16A16UIntNormalized = 11, // 0x0000000B
    R16G16B16A16UInt = 12, // 0x0000000C
    R16G16B16A16IntNormalized = 13, // 0x0000000D
    R16G16B16A16Int = 14, // 0x0000000E
    R32G32Typeless = 15, // 0x0000000F
    R32G32Float = 16, // 0x00000010
    R32G32UInt = 17, // 0x00000011
    R32G32Int = 18, // 0x00000012
    R32G8X24Typeless = 19, // 0x00000013
    D32FloatS8X24UInt = 20, // 0x00000014
    R32FloatX8X24Typeless = 21, // 0x00000015
    X32TypelessG8X24UInt = 22, // 0x00000016
    R10G10B10A2Typeless = 23, // 0x00000017
    R10G10B10A2UIntNormalized = 24, // 0x00000018
    R10G10B10A2UInt = 25, // 0x00000019
    R11G11B10Float = 26, // 0x0000001A
    R8G8B8A8Typeless = 27, // 0x0000001B
    R8G8B8A8UIntNormalized = 28, // 0x0000001C
    R8G8B8A8UIntNormalizedSrgb = 29, // 0x0000001D
    R8G8B8A8UInt = 30, // 0x0000001E
    R8G8B8A8IntNormalized = 31, // 0x0000001F
    R8G8B8A8Int = 32, // 0x00000020
    R16G16Typeless = 33, // 0x00000021
    R16G16Float = 34, // 0x00000022
    R16G16UIntNormalized = 35, // 0x00000023
    R16G16UInt = 36, // 0x00000024
    R16G16IntNormalized = 37, // 0x00000025
    R16G16Int = 38, // 0x00000026
    R32Typeless = 39, // 0x00000027
    D32Float = 40, // 0x00000028
    R32Float = 41, // 0x00000029
    R32UInt = 42, // 0x0000002A
    R32Int = 43, // 0x0000002B
    R24G8Typeless = 44, // 0x0000002C
    D24UIntNormalizedS8UInt = 45, // 0x0000002D
    R24UIntNormalizedX8Typeless = 46, // 0x0000002E
    X24TypelessG8UInt = 47, // 0x0000002F
    R8G8Typeless = 48, // 0x00000030
    R8G8UIntNormalized = 49, // 0x00000031
    R8G8UInt = 50, // 0x00000032
    R8G8IntNormalized = 51, // 0x00000033
    R8G8Int = 52, // 0x00000034
    R16Typeless = 53, // 0x00000035
    R16Float = 54, // 0x00000036
    D16UIntNormalized = 55, // 0x00000037
    R16UIntNormalized = 56, // 0x00000038
    R16UInt = 57, // 0x00000039
    R16IntNormalized = 58, // 0x0000003A
    R16Int = 59, // 0x0000003B
    R8Typeless = 60, // 0x0000003C
    R8UIntNormalized = 61, // 0x0000003D
    R8UInt = 62, // 0x0000003E
    R8IntNormalized = 63, // 0x0000003F
    R8Int = 64, // 0x00000040
    A8UIntNormalized = 65, // 0x00000041
    R1UIntNormalized = 66, // 0x00000042
    R9G9B9E5SharedExponent = 67, // 0x00000043
    R8G8B8G8UIntNormalized = 68, // 0x00000044
    G8R8G8B8UIntNormalized = 69, // 0x00000045
    BC1Typeless = 70, // 0x00000046
    BC1UIntNormalized = 71, // 0x00000047
    BC1UIntNormalizedSrgb = 72, // 0x00000048
    BC2Typeless = 73, // 0x00000049
    BC2UIntNormalized = 74, // 0x0000004A
    BC2UIntNormalizedSrgb = 75, // 0x0000004B
    BC3Typeless = 76, // 0x0000004C
    BC3UIntNormalized = 77, // 0x0000004D
    BC3UIntNormalizedSrgb = 78, // 0x0000004E
    BC4Typeless = 79, // 0x0000004F
    BC4UIntNormalized = 80, // 0x00000050
    BC4IntNormalized = 81, // 0x00000051
    BC5Typeless = 82, // 0x00000052
    BC5UIntNormalized = 83, // 0x00000053
    BC5IntNormalized = 84, // 0x00000054
    B5G6R5UIntNormalized = 85, // 0x00000055
    B5G5R5A1UIntNormalized = 86, // 0x00000056
    B8G8R8A8UIntNormalized = 87, // 0x00000057
    B8G8R8X8UIntNormalized = 88, // 0x00000058
    R10G10B10XRBiasA2UIntNormalized = 89, // 0x00000059
    B8G8R8A8Typeless = 90, // 0x0000005A
    B8G8R8A8UIntNormalizedSrgb = 91, // 0x0000005B
    B8G8R8X8Typeless = 92, // 0x0000005C
    B8G8R8X8UIntNormalizedSrgb = 93, // 0x0000005D
    BC6HTypeless = 94, // 0x0000005E
    BC6H16UnsignedFloat = 95, // 0x0000005F
    BC6H16Float = 96, // 0x00000060
    BC7Typeless = 97, // 0x00000061
    BC7UIntNormalized = 98, // 0x00000062
    BC7UIntNormalizedSrgb = 99, // 0x00000063
    Ayuv = 100, // 0x00000064
    Y410 = 101, // 0x00000065
    Y416 = 102, // 0x00000066
    NV12 = 103, // 0x00000067
    P010 = 104, // 0x00000068
    P016 = 105, // 0x00000069
    Opaque420 = 106, // 0x0000006A
    Yuy2 = 107, // 0x0000006B
    Y210 = 108, // 0x0000006C
    Y216 = 109, // 0x0000006D
    NV11 = 110, // 0x0000006E
    AI44 = 111, // 0x0000006F
    IA44 = 112, // 0x00000070
    P8 = 113, // 0x00000071
    A8P8 = 114, // 0x00000072
    B4G4R4A4UIntNormalized = 115, // 0x00000073
    P208 = 130, // 0x00000082
    V208 = 131, // 0x00000083
    V408 = 132, // 0x00000084
  }
}
