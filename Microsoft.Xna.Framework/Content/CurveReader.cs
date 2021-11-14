// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Content.CurveReader
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

namespace Microsoft.Xna.Framework.Content
{
  internal class CurveReader : ContentTypeReader<Curve>
  {
    protected internal override Curve Read(ContentReader input, Curve existingInstance)
    {
      Curve curve = existingInstance ?? new Curve();
      curve.PreLoop = (CurveLoopType) input.ReadInt32();
      curve.PostLoop = (CurveLoopType) input.ReadInt32();
      int num1 = input.ReadInt32();
      for (int index = 0; index < num1; ++index)
      {
        float position = input.ReadSingle();
        float num2 = input.ReadSingle();
        float tangentIn = input.ReadSingle();
        float tangentOut = input.ReadSingle();
        CurveContinuity continuity = (CurveContinuity) input.ReadInt32();
        curve.Keys.Add(new CurveKey(position, num2, tangentIn, tangentOut, continuity));
      }
      return curve;
    }

    public override bool CanDeserializeIntoExistingObject => true;
  }
}
