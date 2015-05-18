using System;
using System.Drawing;
using System.Windows.Forms;

class LoginForm
{
    /// <summary>
    /// ログインフォーム呼び出し
    /// </summary>
    static void Main()
    {
        Application.Run(new FormLogin());
    }
}

class FormLogin : Form
{
    /// <summary>
    /// ログインフォームのコントロール定義
    /// (別のパブリッククラスで定義した方が便利げ？)
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

    //int count = 0;

    public FormLogin()
    {
        /// <summary>
        /// ログインフォームのデザイン定義
        /// </summary>
        this.Width = 775;
        this.Height = 550;
        this.Text = "従業員基本情報管理台帳　ログイン";

        /* 各コントロール配置 */

        //タイトルロゴ画像
        //this.PictureboxTitle = new PictureBox();
        //this.PictureboxTitle.Location = new Point(115, 20);
        //this.PictureboxTitle.Size = new Size(530, 150);

        //最終更新日時（見出しラベル）
        this.LabelLastupdate = new Label();
        this.LabelLastupdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.LabelLastupdate.Location = new Point(183, 208);
        this.LabelLastupdate.Size = new Size(115, 20);
        this.LabelLastupdate.Font = new Font("MS UI Gothic", 10);
        this.LabelLastupdate.Text = "最終更新日時";
        this.LabelLastupdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.Controls.Add(this.LabelLastupdate);

        //最終更新日時（日付表示ラベル)
        this.LabelDate = new Label();
        this.LabelDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.LabelDate.Location = new Point(308, 208);
        this.LabelDate.Size = new Size(150, 20);
        this.LabelDate.Font = new Font("MS UI Gothic", 10);
        //(以下2行仮置き)現在の日付と時刻を取得　※本番では最終ログイン日時を表示する(初回起動時の表示内容については検討中)
        dateLastupdate = DateTime.Now;
        strLastupdate = dateLastupdate.ToString("yyyy/MM/dd (ddd) HH:mm");
        this.LabelDate.Text = strLastupdate;
        this.LabelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.Controls.Add(this.LabelDate);

        //ID（見出しラベル）
        this.LabelId = new Label();
        this.LabelId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.LabelId.Location = new Point(210, 265);
        this.LabelId.Size = new Size(40, 27);
        this.LabelId.Font = new Font("MS UI Gothic", 15);
        this.LabelId.Text = "ID";
        this.LabelId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.Controls.Add(this.LabelId);
        //ID入力欄
        this.TextboxId = new TextBox();
        this.TextboxId.Location = new Point(255, 265);
        this.TextboxId.Size = new Size(250, 27);
        this.TextboxId.Font = new Font("MS UI Gothic", 15);
        this.Controls.Add(this.TextboxId);

        //パスワード（見出しラベル）
        this.LabelPw = new Label();
        this.LabelPw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.LabelPw.Location = new Point(150, 323);
        this.LabelPw.Size = new Size(100, 27);
        this.LabelPw.Font = new Font("MS UI Gothic", 15);
        this.LabelPw.Text = "ID";
        this.LabelPw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        this.Controls.Add(this.LabelPw);
        //パスワード入力欄
        this.TextboxPw = new TextBox();
        this.TextboxPw.Location = new Point(255, 323);
        this.TextboxPw.Size = new Size(250, 27);
        this.TextboxId.Font = new Font("MS UI Gothic", 15);
        this.TextboxId.MaxByteLength = 8;
        this.Controls.Add(this.TextboxPw);



        //this.button1.Click += new EventHandler(this.Button1_Click);

        //this.Controls.Add(this.button1);
    }

    /*  void Button1_Click(object sender, EventArgs e)
      {
        this.count++;
        this.button1.Text = this.count.ToString();
      }*/
}
