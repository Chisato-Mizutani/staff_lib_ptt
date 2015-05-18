using System;
using System.Drawing;
using System.Windows.Forms;

namespace StafflistF
{
    static class StafflistForm
    {
        /// <summary>
        /// 社員リストフォーム呼び出し
        /// </summary>
        public static void CallStafflist()
        {
            Application.Run(new FormStafflistClass());
        }
    }

    public class FormStafflistClass : Form
    {
        /// <summary>
        /// 社員リストフォーム部品
        /// </summary>
        Label LabelStafflist;              //タイトルラベル
        ComboBox ComboboxItemST;           //項目選択ボックス
        TextBox TextboxSearchST;           //フリーワード入力欄
        Button ButtonSearchST;             //検索ボタン
        Button ButtonPrintST;              //印刷ボタン
        Button ButtonCloseST;              //閉じるボタン
        ListView ListviewStaff;            //従業員リスト


        /// <summary>
        /// フォーム内表示用変数
        /// </summary>

        //リストボックス内カラム、コンボボックス内アイテム
        string[] StrItemST = { "　", "社員番号", "会社名", "所属部署", "氏名", "生年月日", "年齢", "性別", "入社日", "退社日", "編集", "複製", "最終更新日時" };

        int intItemST;      //配列の値設定要変数
        int intMaxitemST;   //配列の最大値を格納


        public void FormStafflist()
        {
            /// <summary>
            /// 社員リストフォームのデザイン定義
            /// </summary>
            this.Width = 1555;
            this.Height = 1100;
            this.Text = "社員リスト";

            /* 各コントロール配置 */

            //タイトルラベル
            LabelStafflist = new Label();
            LabelStafflist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            LabelStafflist.Location = new Point(20, 20);
            LabelStafflist.Size = new Size(150, 35);
            LabelStafflist.Font = new Font("MS UI Gothic", 15,FontStyle.Bold);
            LabelStafflist.Text = "社員リスト";
            LabelStafflist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(LabelStafflist);

            //項目選択ボックス
            ComboboxItemST = new ComboBox();
            ComboboxItemST.Location = new Point(20, 75);
            ComboboxItemST.Size = new Size(130, 21);
            ComboboxItemST.Font = new Font("MS UI Gothic", 10);
            ComboboxItemST.Text = "項目選択";

            //コンボボックスに選択項目を格納する
            intItemST = 1;
            intMaxitemST=(int)StrItemST.Length;
            do
            {
                ComboboxItemST.Items.Add(StrItemST[intItemST]);
                intItemST++;
            }
            while (intItemST > intMaxitemST);

            this.Controls.Add(ComboboxItemST);

            //フリーワード入力欄
            TextboxSearchST = new TextBox();
            TextboxSearchST.Location = new Point(170, 75);
            TextboxSearchST.Size = new Size(150, 20);
            TextboxSearchST.Font = new Font("MS UI Gothic", 10);
            TextboxSearchST.ForeColor = Color.Gray;
            TextboxSearchST.Text = "検索したい文字列を入力";
            this.Controls.Add(TextboxSearchST);

            //検索ボタン
            ButtonSearchST = new Button();
            ButtonSearchST.Location = new Point(535, 75);
            ButtonSearchST.Size = new Size(90, 21);
            ButtonSearchST.Font = new Font("MS UI Gothic", 10);
            ButtonSearchST.Text = "検索";
            ButtonSearchST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(ButtonSearchST);

            //印刷ボタン
            ButtonPrintST = new Button();
            ButtonPrintST.Location = new Point(700, 75);
            ButtonPrintST.Size = new Size(90, 21);
            ButtonPrintST.Font = new Font("MS UI Gothic", 10);
            ButtonPrintST.Text = "印刷";
            ButtonPrintST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(ButtonPrintST);

            //閉じるボタン
            ButtonCloseST = new Button();
            ButtonCloseST.Location = new Point(835, 75);
            ButtonCloseST.Size = new Size(90, 21);
            ButtonCloseST.Font = new Font("MS UI Gothic", 10);
            ButtonCloseST.Text = "印刷";
            this.Controls.Add(ButtonCloseST);

            //従業員リスト ※あとでちゃんとつくる
            ListviewStaff = new ListView();
            ListviewStaff.View = View.Details;
            ListviewStaff.Location = new Point(20, 115);
            ListviewStaff.Size = new Size(1500, 911);
            ListviewStaff.Font = new Font("MS UI Gothic", 10);
            this.Controls.Add(ListviewStaff);

        }
    }
}
