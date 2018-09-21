using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Location_Point_is_Polygon
{
    class Feasibility
    {
        #region Calcute Plate and Map
        public static double PI = 3.14159265;
        public static double TWOPI = 2 * PI;
        public static bool Feasibility_Check(double latitude, double longitude, List<Double> lat_array, List<Double> long_array)
        {
            int i;
            double angle = 0;
            double point1_lat;
            double point1_long;
            double point2_lat;
            double point2_long;
            int n = lat_array.Count();

            for (i = 0; i < n; i++)
            {
                point1_lat = lat_array[i] - latitude;
                point1_long = long_array[i] - longitude;
                point2_lat = lat_array[(i + 1) % n] - latitude;
                point2_long = long_array[(i + 1) % n] - longitude;
                angle += Angle2D(point1_lat, point1_long, point2_lat, point2_long);
            }

            if (Math.Abs(angle) < PI)
                return false;
                else
                    return true;
            }

            public static double Angle2D(double y1, double x1, double y2, double x2)
            {
                double dtheta, theta1, theta2;
            theta1 = Math.Atan2(y1, x1);
            theta2 = Math.Atan2(y2, x2);
            dtheta = theta2 - theta1;
            while (dtheta > PI)
                dtheta -= TWOPI;
            while (dtheta < -PI)
                dtheta += TWOPI;

            return (dtheta);
        }

        public static bool is_valid_gps_coordinate(double latitude, double longitude)
        {
            if (latitude > -90 && latitude < 90 &&
                    longitude > -180 && longitude < 180)
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
