using System;
using System.Drawing;
using System.Windows.Forms;

namespace CompanionlistF
{
    static class FormCompanionlist
    {
        /// <summary>
        /// 社交リストフォーム呼び出し
        /// </summary>
        public static void CallCompanionlist()
        {
            Application.Run(new FormCompanionlistClass());
        }
    }

    public class FormCompanionlistClass : Form
    {
        /// <summary>
        /// 社交リストフォーム部品
        /// </summary>
        Label LabelCompanionlist;              //タイトルラベル
        ComboBox ComboBoxItemCP;                 //項目選択ボックス
        TextBox TextBoxSearchCP;                 //フリーワード入力欄
        Button ButtonSearchCP;                   //検索ボタン
        Button ButtonPrintCP;                    //印刷ボタン
        Button ButtonCloseCP;                    //閉じるボタン
        ListView ListviewCompanion;            //従業員リスト


        /// <summary>
        /// フォーム内表示用変数
        /// </summary>

        //リストボックス内カラム、コンボボックス内アイテム
        string[] StrItemCP = { "　", "社交番号", "会社名", "所属部署", "社交番号","社交名","氏名", "生年月日", "年齢", "性別", "入社日", "退社日", "編集", "複製", "最終更新日時" };

        int intItemCP;      //配列の値設定要変数
        int intMaxitemCP;   //配列の最大値を格納


        public void FormCompanionlist()
        {
            /// <summary>
            /// リストフォームのデザイン定義
            /// </summary>
            this.Width = 1555;
            this.Height = 1100;
            this.Text = "社交リスト";

            /* 各コントロール配置 */

            //タイトルラベル
            LabelCompanionlist = new Label();
            LabelCompanionlist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            LabelCompanionlist.Location = new Point(20, 20);
            LabelCompanionlist.Size = new Size(150, 35);
            LabelCompanionlist.Font = new Font("MS UI Gothic", 15, FontStyle.Bold);
            LabelCompanionlist.Text = "社交リスト";
            LabelCompanionlist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(LabelCompanionlist);

            //項目選択ボックス
            ComboBoxItemCP = new ComboBox();
            ComboBoxItemCP.Location = new Point(20, 75);
            ComboBoxItemCP.Size = new Size(130, 21);
            ComboBoxItemCP.Font = new Font("MS UI Gothic", 10);
            ComboBoxItemCP.Text = "項目選択";

            //コンボボックスに選択項目を格納する
            intItemCP = 1;
            intMaxitemCP = (int)StrItemCP.Length;
            do
            {
                ComboBoxItemCP.Items.Add(StrItemCP[intItemCP]);
                intItemCP++;
            }
            while (intItemCP > intMaxitemCP);

            this.Controls.Add(ComboBoxItemCP);

            //フリーワード入力欄
            TextBoxSearchCP = new TextBox();
            TextBoxSearchCP.Location = new Point(170, 75);
            TextBoxSearchCP.Size = new Size(150, 20);
            TextBoxSearchCP.Font = new Font("MS UI Gothic", 10);
            TextBoxSearchCP.ForeColor = Color.Gray;
            TextBoxSearchCP.Text = "検索したい文字列を入力";
            this.Controls.Add(TextBoxSearchCP);

            //検索ボタン
            ButtonSearchCP = new Button();
            ButtonSearchCP.Location = new Point(535, 75);
            ButtonSearchCP.Size = new Size(90, 21);
            ButtonSearchCP.Font = new Font("MS UI Gothic", 10);
            ButtonSearchCP.Text = "検索";
            ButtonSearchCP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(ButtonSearchCP);

            //印刷ボタン
            ButtonPrintCP = new Button();
            ButtonPrintCP.Location = new Point(700, 75);
            ButtonPrintCP.Size = new Size(90, 21);
            ButtonPrintCP.Font = new Font("MS UI Gothic", 10);
            ButtonPrintCP.Text = "印刷";
            ButtonPrintCP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(ButtonPrintCP);

            //閉じるボタン
            ButtonCloseCP = new Button();
            ButtonCloseCP.Location = new Point(835, 75);
            ButtonCloseCP.Size = new Size(90, 21);
            ButtonCloseCP.Font = new Font("MS UI Gothic", 10);
            this.Controls.Add(ButtonCloseCP);

            //従業員リスト ※あとでちゃんとつくる
            ListviewCompanion = new ListView();
            ListviewCompanion.View = View.Details;
            ListviewCompanion.Location = new Point(20, 115);
            ListviewCompanion.Size = new Size(1500, 911);
            ListviewCompanion.Font = new Font("MS UI Gothic", 10);
            this.Controls.Add(ListviewCompanion);

        }
    }
}
