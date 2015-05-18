using System;
using System.Drawing;
using System.Windows.Forms;

namespace SelectdataF
{
    class SelectdataForm
    {
        /// <summary>
        /// 参照データ選択フォーム
        /// </summary>
        public static void CallSelectdata()
        {
            Application.Run(new FormSelectdataClass());
        }
    }

    public class FormSelectdataClass : Form
    {
        /// <summary>
        /// 参照データ選択フォーム部品
        /// </summary>
        Label LabelSelectdata;       //タイトルラベル
        GroupBox GroupboxStaff;      //社員情報グループ
        GroupBox GroupboxCompanion;  //社交情報グループ
        Button ButtonAddstaff;       //社員情報新規登録ボタン
        Button ButtonRefstaff;       //社員情報参照ボタン
        Button ButtonAddcompanion;   //社交情報新規登録ボタン
        Button ButtonRefcompanion;   //社交情報参照ボタン
        Button ButtonLogout;         //ログアウトボタン
        Button ButtonExit;           //終了ボタン

        public void FormSelectdata()
        {
            /// <summary>
            /// 参照データ選択フォームのデザイン定義
            /// </summary>
            this.Width = 775;
            this.Height = 550;
            this.Text = "参照データ選択";

            /* 各コントロール配置 */

            //タイトルラベル
            LabelSelectdata = new Label();
            LabelSelectdata.Location = new Point(95, 35);
            LabelSelectdata.Size = new Size(550, 60);
            GroupboxStaff.Font = new Font("MS UI Gothic", 10);
            LabelSelectdata.Text = "参照データ選択";
            this.Controls.Add(LabelSelectdata);

            //社員情報グループ
            GroupboxStaff = new GroupBox();
            GroupboxStaff.Location = new Point(95, 140);
            GroupboxStaff.Size = new Size(550, 150);
            GroupboxStaff.Font = new Font("MS UI Gothic", 16, FontStyle.Bold);
            GroupboxStaff.Text = "社員情報";
            this.Controls.Add(GroupboxStaff);

            //社員情報新規登録ボタン
            ButtonAddstaff = new Button();
            ButtonAddstaff.Location = new Point(95 + GroupboxStaff.Location.X, 325 + GroupboxStaff.Location.Y);
            ButtonAddstaff.Size = new Size(160, 50);
            ButtonAddstaff.Font = new Font("MS UI Gothic", 15, FontStyle.Bold);
            ButtonRefstaff.Text = "新規登録";
            this.Controls.Add(ButtonAddstaff);

            //社員情報参照ボタン
            ButtonRefstaff = new Button();
            ButtonRefstaff.Location = new Point(325 + GroupboxStaff.Location.X, 55 + GroupboxStaff.Location.Y);
            ButtonRefstaff.Size = new Size(160, 50);
            ButtonRefstaff.Font = new Font("MS UI Gothic", 15, FontStyle.Bold);
            ButtonRefstaff.Text = "参照";
            ButtonRefstaff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(ButtonRefstaff);

            //社交情報グループ
            GroupboxCompanion = new GroupBox();
            GroupboxCompanion.Location = new Point(95, 325);
            GroupboxCompanion.Size = new Size(550, 150);
            GroupboxCompanion.Font = new Font("MS UI Gothic", 16, FontStyle.Bold);
            GroupboxCompanion.Text = "社交情報";
            this.Controls.Add(GroupboxCompanion);

            //社交情報新規登録ボタン
            ButtonAddcompanion = new Button();
            ButtonAddcompanion.Location = new Point(65 + GroupboxCompanion.Location.X, 55 + GroupboxCompanion.Location.Y);
            ButtonAddcompanion.Size = new Size(160, 50);
            ButtonAddcompanion.Font = new Font("MS UI Gothic", 15, FontStyle.Bold);
            ButtonAddcompanion.Text = "新規登録";
            ButtonAddcompanion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(ButtonAddcompanion);

            //社交情報参照ボタン
            ButtonRefcompanion = new Button();
            ButtonRefcompanion.Location = new Point(325 + GroupboxCompanion.Location.X, 55 + GroupboxCompanion.Location.Y);
            ButtonRefcompanion.Size = new Size(160, 50);
            ButtonRefcompanion.Font = new Font("MS UI Gothic", 15, FontStyle.Bold);
            ButtonRefcompanion.Text = "参照";
            ButtonRefcompanion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(ButtonRefcompanion);

            //ログアウトボタン
            ButtonLogout = new Button();
            ButtonLogout.Location = new Point(665, 430);
            ButtonLogout.Size = new Size(80, 30);
            ButtonLogout.Font = new Font("MS UI Gothic", 10);
            ButtonLogout.Text = "ログアウト";
            ButtonLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(ButtonLogout);

            //終了ボタン
            ButtonExit = new Button();
            ButtonExit.Location = new Point(665, 465);
            ButtonExit.Size = new Size(80, 30);
            ButtonExit.Font = new Font("MS UI Gothic", 10);
            ButtonExit.Text = "終了";
            ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(ButtonExit);
        }
    }
}
