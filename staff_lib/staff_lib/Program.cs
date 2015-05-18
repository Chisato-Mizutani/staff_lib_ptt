using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using LoginF.LoginForm;
using SelectdataF.SelectdataForm;

/// <summary>
/// 各フォームのコントロール定義
/// </summary>
namespace staff_lib
{
    static void Main(string[] args)
    {
        class CallLogin
        {
            LoginF.LoginForm.Login();
        }
        class CallSelectdata
        {
            SelectdataF.SelectdataForm.Selectdata();
        }
    }
}
