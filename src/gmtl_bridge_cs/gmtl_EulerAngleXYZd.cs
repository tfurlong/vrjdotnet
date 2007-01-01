#region License
// VRJ.NET is (C) Copyright 2004 by Patrick Hartling
// Distributed under the GNU Lesser General Public License 2.1.  (See
// accompanying file COPYING.txt or http://www.gnu.org/copyleft/lesser.txt)
#endregion License

// Generated from Revision: 1.79 of RCSfile: class_cs.tmpl,v
using System;
using System.Runtime.InteropServices;
using System.Reflection;





namespace gmtl
{

public sealed class EulerAngleXYZd
{
   private IntPtr mRawObject = IntPtr.Zero;
   private bool mWeOwnMemory = false;

   /// <summary>
   /// This is needed for the custom marshaler to be able to perform a
   /// reflective lookup.  The custom marshaler also uses this method to get
   /// access to the value of mRawObject when necessary.
   /// </summary>
   public IntPtr RawObject
   {
      get { return mRawObject; }
   }

   // Constructors.
   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_EulerAngle_double_gmtl_XYZ__EulerAngle__0();

   public EulerAngleXYZd()
   {
      mRawObject   = gmtl_EulerAngle_double_gmtl_XYZ__EulerAngle__0();
      mWeOwnMemory = true;
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_EulerAngle_double_gmtl_XYZ__EulerAngle__gmtl_EulerAngleXYZd1([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(gmtl.EulerAngleXYZdMarshaler))] gmtl.EulerAngleXYZd p0);

   public EulerAngleXYZd(gmtl.EulerAngleXYZd p0)
   {
      mRawObject   = gmtl_EulerAngle_double_gmtl_XYZ__EulerAngle__gmtl_EulerAngleXYZd1(p0);
      mWeOwnMemory = true;
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static IntPtr gmtl_EulerAngle_double_gmtl_XYZ__EulerAngle__double_double_double3(double p0, double p1, double p2);

   public EulerAngleXYZd(double p0, double p1, double p2)
   {
      mRawObject   = gmtl_EulerAngle_double_gmtl_XYZ__EulerAngle__double_double_double3(p0, p1, p2);
      mWeOwnMemory = true;
   }

   // Internal constructor needed for marshaling purposes.
   internal EulerAngleXYZd(IntPtr instPtr, bool ownMemory)
   {
      mRawObject   = instPtr;
      mWeOwnMemory = ownMemory;
   }

   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static void delete_gmtl_EulerAngleXYZd(IntPtr obj);

   // Destructor.
   ~EulerAngleXYZd()
   {
      if ( mWeOwnMemory && IntPtr.Zero != mRawObject )
      {
         delete_gmtl_EulerAngleXYZd(mRawObject);
         mWeOwnMemory = false;
         mRawObject   = IntPtr.Zero;
      }
   }

   // Operator overloads.

   // Converter operators.

   // Start of non-virtual methods.
   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static void gmtl_EulerAngle_double_gmtl_XYZ__set__double_double_double3(IntPtr obj,
	double p0,
	double p1,
	double p2);

   public  void set(double p0, double p1, double p2)
   {
      gmtl_EulerAngle_double_gmtl_XYZ__set__double_double_double3(mRawObject, p0, p1, p2);
   }


   [DllImport("gmtl_bridge", CharSet = CharSet.Ansi)]
   private extern static void gmtl_EulerAngle_double_gmtl_XYZ__getData__0(IntPtr obj,
	[In, Out] double[] arrayHolder);

   public  double[] getData()
   {
      double[] array_holder = new double[3];
      gmtl_EulerAngle_double_gmtl_XYZ__getData__0(mRawObject, array_holder);
      return array_holder;
   }


   // End of non-virtual methods.

   // Start of virtual methods.
   // End of virtual methods.

   // Nested enumeration gmtl.EulerAngle<double,gmtl.XYZ>.Params.
   public enum Params
   {
      Order = 0, Size = 3
   };


} // class gmtl.EulerAngleXYZd

/// <summary>
/// Custom marshaler for gmtl.EulerAngleXYZd.  Use this with P/Invoke
/// calls when a C# object of this type needs to be passed to native code or
/// vice versa.  Essentially, this marshaler hides the existence of mRawObject.
/// </summary>
public class EulerAngleXYZdMarshaler : ICustomMarshaler
{
   public void CleanUpManagedData(Object obj)
   {
   }

   public void CleanUpNativeData(IntPtr nativeData)
   {
   }

   public int GetNativeDataSize()
   {
      return -1;
   }

   // Marshaling for managed data being passed to C++.
   public IntPtr MarshalManagedToNative(Object obj)
   {
      return ((gmtl.EulerAngleXYZd) obj).RawObject;
   }

   // Marshaling for native memory coming from C++.
   public Object MarshalNativeToManaged(IntPtr nativeObj)
   {
      return new gmtl.EulerAngleXYZd(nativeObj, false);
   }

   public static ICustomMarshaler GetInstance(string cookie)
   {
      return mInstance;
   }

   private static EulerAngleXYZdMarshaler mInstance = new EulerAngleXYZdMarshaler();
}


} // namespace gmtl
