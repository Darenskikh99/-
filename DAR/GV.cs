using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAR
{
    class GV
    {
        public static int M = 100, MR = 50, MF = 20;
        public static int nv, n, nr, nc, nl, nf, lp, lm, kp, km, k;

        public static int[,] in_r = new int[MR + 1, 2];
        public static float[] z_r = new float[MR + 1];


        public static int[,] in_c = new int[MR + 1, 2];
        public static float[] mu_c = new float[MR + 1];

        public static int[,] in_l = new int[MR + 1, 2];
        public static float[] gn_l = new float[MR + 1];

        public static float[] f = new float[MF + 1];
        //...
        public static String filename;
        public static bool flag = false;
    }
}
