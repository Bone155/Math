﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circles_Spheres
{
    class Sphere
    {
        Vector3 center;
        float radius;

        public Sphere()
        {
        }

        public Sphere(Vector3 p, float r)
        {
            center = p;
            radius = r;
        }

        public void Fit(Vector3[] points)
        {
            // invalidate extents
            Vector3 min = new Vector3(float.MaxValue, float.MaxValue, float.MaxValue);

            Vector3 max = new Vector3(float.MinValue, float.MinValue, float.MinValue);

            // find min and max of the points
            for (int i = 0; i < points.Length; ++i)
            {
                min = Vector3.Min(min, points[i]);
                max = Vector3.Max(max, points[i]);
            }

            // put a circle around the min/max box
            center = (min + max) * 0.5f;
            radius = center.Distance(max);
        }

        public bool Overlaps(Vector3 p)
        {
            Vector3 toPoint = p - center;
            return toPoint.MagnitudeSqr() <= (radius * radius);
        }

        public bool Overlaps(Sphere other)
        {
            Vector3 diff = other.center - center;
            // compare distance between spheres to combined radii
            float r = radius + other.radius;
            return diff.MagnitudeSqr() <= (r * r);
        }

        public bool Overlaps(AABB aabb)
        {
            Vector3 diff = aabb.ClosestPoint(center) - center;
            return diff.Dot(diff) <= (radius * radius);
        }

        Vector3 ClosestPoint(Vector3 p)
        {
            // distance from center
            Vector3 toPoint = p - center;
            // if outside of radius bring it back to the radius
            if (toPoint.MagnitudeSqr() > radius * radius)
            {
                toPoint = toPoint.GetNormalised() * radius;
            }
            return center + toPoint;
        }
    }
}
