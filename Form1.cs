using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniMaxSum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //List<int> arr = new List<int>() { 7, 69, 2, 221, 8974 };
            List<int> arr = new List<int>() { 256741038, 623958417, 467905213, 714532089, 938071625 };
            //List<int> arr = new List<int>() { 5, 5, 5, 5, 5 };
            //List<int> arr = new List<int>() { 1, 2, 3, 4, 5 };
            miniMaxSum(arr);
        }
        public static void miniMaxSum(List<int> arr)
        {
            long min = arr[0], max = arr[0];
            long sum = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
                sum += arr[i];
            }

            Console.WriteLine(Convert.ToString((sum - max) + " " + (sum - min)));
        }
    }
}
