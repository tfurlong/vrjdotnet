/*************** <auto-copyright.pl BEGIN do not edit this line> **************
 *
 * VRJ.NET is (C) Copyright 2004 by Patrick Hartling
 *
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Library General Public
 * License as published by the Free Software Foundation; either
 * version 2 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Library General Public License for more details.
 *
 * You should have received a copy of the GNU Library General Public
 * License along with this library; if not, write to the
 * Free Software Foundation, Inc., 59 Temple Place - Suite 330,
 * Boston, MA 02111-1307, USA.
 *
 * -----------------------------------------------------------------
 * File:          $RCSfile$
 * Date modified: $Date$
 * Version:       $Revision$
 * -----------------------------------------------------------------
 *
 *************** <auto-copyright.pl END do not edit this line> ***************/

// Generated from Revision: 1.60 of RCSfile: class_cxx.tmpl,v



#include "sharppy.h"
#include <gmtl/EulerAngle.h>

extern "C"
{
   // Constructor wrapper.
   SHARPPY_API gmtl::EulerAngleXYZd* gmtl_EulerAngle_double_gmtl_XYZ__EulerAngle__()
   {
      gmtl::EulerAngleXYZd* obj = new gmtl::EulerAngleXYZd();
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API gmtl::EulerAngleXYZd* gmtl_EulerAngle_double_gmtl_XYZ__EulerAngle__gmtl_EulerAngleXYZd(const gmtl::EulerAngleXYZd* p0)
   {
      const gmtl::EulerAngleXYZd& marshal_p0 = *p0; // Pre-call marshaling for p0
      gmtl::EulerAngleXYZd* obj = new gmtl::EulerAngleXYZd(marshal_p0);
      ; // Post-call marshaling for p0
      return obj;
   }

   // Constructor wrapper.
   SHARPPY_API gmtl::EulerAngleXYZd* gmtl_EulerAngle_double_gmtl_XYZ__EulerAngle__double_double_double(double p0, double p1, double p2)
   {
      gmtl::EulerAngleXYZd* obj = new gmtl::EulerAngleXYZd(p0, p1, p2);
      return obj;
   }

   SHARPPY_API void delete_gmtl_EulerAngleXYZd(gmtl::EulerAngleXYZd* self_)
   {
      delete self_;
   }

   // Wrapper for non-virtual method gmtl::EulerAngle<double,gmtl::XYZ>::set()
   SHARPPY_API void gmtl_EulerAngle_double_gmtl_XYZ__set__double_double_double3(gmtl::EulerAngleXYZd* self_, const double p0, const double p1, const double p2)
   {
      self_->set(p0, p1, p2);
   }


   // Wrapper for non-virtual method gmtl::EulerAngle<double,gmtl::XYZ>::getData()
   SHARPPY_API double* gmtl_EulerAngle_double_gmtl_XYZ__getData__0(gmtl::EulerAngleXYZd* self_)
   {
      double* result;
      result = self_->getData();
      return result;
   }

/*
   // Wrapper for non-virtual method gmtl::EulerAngle<double,gmtl::XYZ>::getData()
   SHARPPY_API const double* gmtl_EulerAngle_double_gmtl_XYZ__getData__0(gmtl::EulerAngleXYZd* self_)
   {
      const double* result;
      result = self_->getData();
      return result;
   }
*/

} // extern "C" for gmtl::EulerAngleXYZd


