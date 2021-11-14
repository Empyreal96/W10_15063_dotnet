// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Audio.UnsafeNativeStructures
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

namespace Microsoft.Xna.Framework.Audio
{
  internal static class UnsafeNativeStructures
  {
    internal static Vector3 FlipHandedness(Vector3 vector)
    {
      Vector3 vector3;
      vector3.X = vector.X;
      vector3.Y = vector.Y;
      vector3.Z = -vector.Z;
      return vector3;
    }

    internal struct XACT_LISTENER_DATA
    {
      internal Vector3 _Forward;
      internal Vector3 _Up;
      internal Vector3 _Position;
      internal Vector3 _Velocity;
      private unsafe void* pCone;
    }

    internal struct XACT_EMITTER_DATA
    {
      internal unsafe void* pCone;
      internal Vector3 _Forward;
      internal Vector3 _Up;
      internal Vector3 _Position;
      internal Vector3 _Velocity;
      internal float _innerRadius;
      internal float _innerRadiusAngle;
      internal uint ChannelCount;
      internal float ChannelRadius;
      internal unsafe float* pChannelAzimuths;
      internal unsafe void* pVolumeCurve;
      internal unsafe void* pLfeCurve;
      internal unsafe void* pLpfDirectCurve;
      internal unsafe void* pLpfReverbCurve;
      internal unsafe void* pReverbCurve;
      internal float CurveDistanceScaler;
      internal float _DopplerScale;
    }
  }
}
