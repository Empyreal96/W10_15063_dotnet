// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.ErrorCodes
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

namespace Microsoft.Xna.Framework
{
  internal enum ErrorCodes : uint
  {
    Success = 0,
    AccessDenied = 5,
    Busy = 170, // 0x000000AA
    AlreadyExists = 183, // 0x000000B7
    Pending = 997, // 0x000003E5
    NotConnected = 1167, // 0x0000048F
    Empty = 4306, // 0x000010D2
    E_NOTIMPL = 2147500033, // 0x80004001
    E_ABORT = 2147500036, // 0x80004004
    E_FAIL = 2147500037, // 0x80004005
    REGDB_E_CLASSNOTREG = 2147746132, // 0x80040154
    VFW_E_NO_AUDIO_HARDWARE = 2147746390, // 0x80040256
    E_ACCESSDENIED = 2147942405, // 0x80070005
    E_OUTOFMEMORY = 2147942414, // 0x8007000E
    ERROR_SHARING_VIOLATION = 2147942432, // 0x80070020
    E_INVALIDARG = 2147942487, // 0x80070057
    STRSAFE_E_INSUFFICIENT_BUFFER = 2147942522, // 0x8007007A
    DIRECTRENDERING_E_INVALID_MODE = 2150814720, // 0x8032D400
    DIRECTRENDERING_E_ELEMENT_NOT_IN_VISUALTREE = 2281703676, // 0x880008FC
    D3DERR_OUTOFVIDEOMEMORY = 2289435004, // 0x8876017C
    D3DERR_WRONGTEXTUREFORMAT = 2289436696, // 0x88760818
    D3DERR_TOOMANYOPERATIONS = 2289436701, // 0x8876081D
    D3DERR_DRIVERINTERNALERROR = 2289436711, // 0x88760827
    D3DERR_NOTFOUND = 2289436774, // 0x88760866
    D3DERR_MOREDATA = 2289436775, // 0x88760867
    D3DERR_DEVICELOST = 2289436776, // 0x88760868
    D3DERR_DEVICENOTRESET = 2289436777, // 0x88760869
    D3DERR_NOTAVAILABLE = 2289436784, // 0x88760870
    D3DERR_INVALIDCALL = 2289436786, // 0x88760872
    XACTENGINE_E_ALREADYINITIALIZED = 2328297473, // 0x8AC70001
    XACTENGINE_E_NOTINITIALIZED = 2328297474, // 0x8AC70002
    XACTENGINE_E_EXPIRED = 2328297475, // 0x8AC70003
    XACTENGINE_E_NONOTIFICATIONCALLBACK = 2328297476, // 0x8AC70004
    XACTENGINE_E_NOTIFICATIONREGISTERED = 2328297477, // 0x8AC70005
    XACTENGINE_E_INVALIDUSAGE = 2328297478, // 0x8AC70006
    XACTENGINE_E_INVALIDDATA = 2328297479, // 0x8AC70007
    XACTENGINE_E_INSTANCELIMITFAILTOPLAY = 2328297480, // 0x8AC70008
    XACTENGINE_E_NOGLOBALSETTINGS = 2328297481, // 0x8AC70009
    XACTENGINE_E_INVALIDVARIABLEINDEX = 2328297482, // 0x8AC7000A
    XACTENGINE_E_INVALIDCATEGORY = 2328297483, // 0x8AC7000B
    XACTENGINE_E_INVALIDCUEINDEX = 2328297484, // 0x8AC7000C
    XACTENGINE_E_INVALIDWAVEINDEX = 2328297485, // 0x8AC7000D
    XACTENGINE_E_INVALIDTRACKINDEX = 2328297486, // 0x8AC7000E
    XACTENGINE_E_INVALIDSOUNDOFFSETORINDEX = 2328297487, // 0x8AC7000F
    XACTENGINE_E_READFILE = 2328297488, // 0x8AC70010
    XACTENGINE_E_UNKNOWNEVENT = 2328297489, // 0x8AC70011
    XACTENGINE_E_INCALLBACK = 2328297490, // 0x8AC70012
    XACTENGINE_E_NOWAVEBANK = 2328297491, // 0x8AC70013
    XACTENGINE_E_SELECTVARIATION = 2328297492, // 0x8AC70014
    XACTENGINE_E_MULTIPLEAUDITIONENGINES = 2328297493, // 0x8AC70015
    XACTENGINE_E_WAVEBANKNOTPREPARED = 2328297494, // 0x8AC70016
    XACTENGINE_E_NORENDERER = 2328297495, // 0x8AC70017
    XACTENGINE_E_INVALIDENTRYCOUNT = 2328297496, // 0x8AC70018
    XACTENGINE_E_SEEKTIMEBEYONDCUEEND = 2328297497, // 0x8AC70019
    XACTENGINE_E_AUDITION_WRITEFILE = 2328297729, // 0x8AC70101
    XACTENGINE_E_AUDITION_NOSOUNDBANK = 2328297730, // 0x8AC70102
    XACTENGINE_E_AUDITION_INVALIDRPCINDEX = 2328297731, // 0x8AC70103
    XACTENGINE_E_AUDITION_MISSINGDATA = 2328297732, // 0x8AC70104
    XACTENGINE_E_AUDITION_UNKNOWNCOMMAND = 2328297733, // 0x8AC70105
    XACTENGINE_E_AUDITION_INVALIDDSPINDEX = 2328297734, // 0x8AC70106
    XACTENGINE_E_AUDITION_MISSINGWAVE = 2328297735, // 0x8AC70107
    XACTENGINE_E_AUDITION_CREATEDIRECTORYFAILED = 2328297736, // 0x8AC70108
    XACTENGINE_E_AUDITION_INVALIDSESSION = 2328297737, // 0x8AC70109
    ZDKSYSTEM_E_AUDIO_INSTANCELIMIT = 2343370753, // 0x8BAD0001
    ZDKSYSTEM_E_AUDIO_INVALIDSTATE = 2343370754, // 0x8BAD0002
    ZDKSYSTEM_E_AUDIO_INVALIDDATA = 2343370755, // 0x8BAD0003
    CAPTURE_ENGINE_E_DEVICEGONE = 2364407809, // 0x8CEE0001
  }
}
