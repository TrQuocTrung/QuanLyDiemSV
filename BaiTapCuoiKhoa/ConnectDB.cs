using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapCuoiKhoa
{
    internal class ConnectDB
    {
       
        private string ConnectionSQl = @"Data Source=LAPTOP-76VQV1PI;Initial Catalog=QuanLyHocTap;Integrated Security=True;";
        public string Getconnect()
        {
            return ConnectionSQl;
        }
    }
   
}
