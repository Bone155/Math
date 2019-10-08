using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class transform
    {                                                                                                                                                          
        public Matrix3 Set(Matrix3 matrix)
        {
            return matrix;
        }

        public Matrix2 Set(Matrix2 matrix)
        {
            return matrix;
        }

        void SetEuler(float pitch, float yaw, float roll)
        {
            Matrix3 x = new Matrix3();
            Matrix3 y = new Matrix3();
            Matrix3 z = new Matrix3();
            x.SetRotateX(pitch);
            y.SetRotateY(yaw);
            z.SetRotateZ(roll);
            // combine rotations in a specific order
            Set(z * y * x);
        }

    }
}
