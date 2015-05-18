using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using LoginF;
using SelectdataF;

namespace StaffLib
{
    class StaffLibMain
    {

        public static void Main()
        {
            /// <summary>
            /// ログインフォーム呼び出し
            /// </summary>
            LoginForm.CallLogin();

            /// <summary>
            /// 参照データ選択フォーム呼び出し
            /// </summary>
            SelectdataForm.CallSelectdata();

        }
    }
}


