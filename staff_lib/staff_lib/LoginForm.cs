using System;
using System.Drawing;
using System.Windows.Forms;

namespace LoginF
{
    static class LoginForm
    {
        /// <summary>
        /// ログインフォーム呼び出し
        /// </summary>
        public static void CallLogin()
        {
            Application.Run(new FormLoginClass());
        }
    }

    public class FormLoginClass : Form
    {
        /// <summary>
        /// ログインフォーム部品
        /// </summary>
        PictureBox PictureboxTitle;  //タイトルロゴ画像表示
        Label LabelLastupdate;       //最終更新日時　タイトルラベル
        Label LabelDate;             //最終更新日時　日時表示ラベル
        Label LabelId;               //ID入力欄　タイトルラベル
        Label LabelPw;               //パスワード入力欄　タイトルラベル
        TextBox TextboxId;           //ID入力欄
        TextBox TextboxPw;           //パスワード入力欄
        Button ButtonLogin;          //ログインボタン
        Button ButtonExit;           //終了ボタン

        /// <summary>
        /// フォーム内表示用変数
        /// </summary>
        DateTime dateLastupdate;      //(仮置き)現在の日付と時刻　※本番では最終ログイン日時を取得する
        string strLastupdate;         //(仮置き)現在の日付と時刻を文字列として格納　※本番では最終ログイン日時を格納する

        public void FormLogin()
        {
            /// <summary>
            /// ログインフォームのデザイン定義
            /// </summary>
            this.Width = 775;
            this.Height = 550;
            this.Text = "従業員基本情報管理台帳　ログイン";

            /* 各コントロール配置 */

            //タイトルロゴ画像
            PictureboxTitle = new PictureBox();
            PictureboxTitle.Location = new Point(115, 20);
            PictureboxTitle.Size = new Size(530, 150);
            this.Controls.Add(PictureboxTitle);

            //最終更新日時（見出しラベル）
            LabelLastupdate = new Label();
            LabelLastupdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            LabelLastupdate.Location = new Point(183, 208);
            LabelLastupdate.Size = new Size(115, 20);
            LabelLastupdate.Font = new Font("MS UI Gothic", 10);
            LabelLastupdate.Text = "最終更新日時";
            LabelLastupdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(LabelLastupdate);

            //最終更新日時（日付表示ラベル)
            LabelDate = new Label();
            LabelDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            LabelDate.Location = new Point(308, 208);
            LabelDate.Size = new Size(150, 20);
            LabelDate.Font = new Font("MS UI Gothic", 10);
            //(以下2行仮置き)現在の日付と時刻を取得　※本番では最終ログイン日時を表示する(初回起動時の表示内容については検討中)
            dateLastupdate = DateTime.Now;
            strLastupdate = dateLastupdate.ToString("yyyy/MM/dd (ddd) HH:mm");
            LabelDate.Text = strLastupdate;
            LabelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(LabelDate);

            //ID（見出しラベル）
            LabelId = new Label();
            LabelId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            LabelId.Location = new Point(210, 265);
            LabelId.Size = new Size(40, 27);
            LabelId.Font = new Font("MS UI Gothic", 15);
            LabelId.Text = "ID";
            LabelId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(LabelId);
            //ID入力欄
            TextboxId = new TextBox();
            TextboxId.Location = new Point(255, 265);
            TextboxId.Size = new Size(250, 27);
            TextboxId.Font = new Font("MS UI Gothic", 15);
            this.Controls.Add(TextboxId);

            //パスワード（見出しラベル）
            LabelPw = new Label();
            LabelPw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            LabelPw.Location = new Point(150, 323);
            LabelPw.Size = new Size(100, 27);
            LabelPw.Font = new Font("MS UI Gothic", 15);
            LabelPw.Text = "パスワード";
            LabelPw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(LabelPw);
            //パスワード入力欄
            TextboxPw = new TextBox();
            TextboxPw.Location = new Point(255, 323);
            TextboxPw.Size = new Size(250, 27);
            TextboxPw.Font = new Font("MS UI Gothic", 15);
            TextboxPw.MaxLength = 4;
            this.Controls.Add(TextboxPw);

            //ログインボタン
            ButtonLogin = new Button();
            ButtonLogin.Location = new Point(255, 380);
            ButtonLogin.Size = new Size(110, 40);
            ButtonLogin.Font = new Font("MS UI Gothic", 10);
            ButtonLogin.Text = "ログイン";
            ButtonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(ButtonLogin);
            //終了ボタン
            ButtonExit = new Button();
            ButtonExit.Location = new Point(395, 380);
            ButtonExit.Size = new Size(110, 40);
            ButtonExit.Font = new Font("MS UI Gothic", 10);
            ButtonExit.Text = "終了";
            ButtonExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(ButtonExit);
        }
    }
}
