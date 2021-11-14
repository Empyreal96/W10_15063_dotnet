// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Data.RBTreeError
// Assembly: Microsoft.Phone.Data.Internal, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 7C603BAB-2692-41A5-9823-E2E1FFE181D1
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5246~1.DLL

namespace Microsoft.Phone.Data
{
  internal enum RBTreeError
  {
    InvalidPageSize = 1,
    PagePositionInSlotInUse = 3,
    NoFreeSlots = 4,
    InvalidStateinInsert = 5,
    InvalidNextSizeInDelete = 7,
    InvalidStateinDelete = 8,
    InvalidNodeSizeinDelete = 9,
    InvalidStateinEndDelete = 10, // 0x0000000A
    CannotRotateInvalidsuccessorNodeinDelete = 11, // 0x0000000B
    IndexOutOFRangeinGetNodeByIndex = 13, // 0x0000000D
    RBDeleteFixup = 14, // 0x0000000E
    UnsupportedAccessMethod1 = 15, // 0x0000000F
    UnsupportedAccessMethod2 = 16, // 0x00000010
    UnsupportedAccessMethodInNonNillRootSubtree = 17, // 0x00000011
    AttachedNodeWithZerorbTreeNodeId = 18, // 0x00000012
    CompareNodeInDataRowTree = 19, // 0x00000013
    CompareSateliteTreeNodeInDataRowTree = 20, // 0x00000014
    NestedSatelliteTreeEnumerator = 21, // 0x00000015
  }
}
