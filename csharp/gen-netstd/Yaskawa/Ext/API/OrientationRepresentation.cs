/**
 * <auto-generated>
 * Autogenerated by Thrift Compiler (0.17.0)
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 * </auto-generated>
 */

#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE0017  // object init can be simplified
#pragma warning disable IDE0028  // collection init can be simplified
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable CA1822   // empty DeepCopy() methods still non-static
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Yaskawa.Ext.API
{
  /// <summary>
  /// Orientations in 3D can be represented either as:
  /// * A 4-element unit-length Quaternion (x,y,z,w)
  /// * A 3x3 transformation matrix
  /// * A 3-vector of Euler angles
  ///     (Tait/Cardan-Bryant) Roll, Pitch, Yaw angles (alpha,beta,gamma).
  ///     This is equivelent to EulerXYZ and assumes that the
  ///      x-axis points forward, y-axis points right and the z-axis up.
  ///      (Aeronautical convention)
  /// </summary>
  public enum OrientationRepresentation
  {
    Quaternion = 0,
    Matrix = 1,
    EulerRPY = 2,
  }
}
