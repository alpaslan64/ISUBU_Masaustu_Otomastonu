namespace Bitirme_Projesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.numara = new Bunifu.UI.WinForms.BunifuTextBox();
            this.sifre = new Bunifu.UI.WinForms.BunifuTextBox();
            this.girisYap = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton2 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuCircleProgress1 = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.geriGetir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.MediumBlue;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Navy;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.DeepSkyBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.DodgerBlue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(337, 554);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 0;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(366, 334);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(367, 335);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(-15, 98);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(367, 335);
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 0;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // numara
            // 
            this.numara.AcceptsReturn = false;
            this.numara.AcceptsTab = false;
            this.numara.AnimationSpeed = 200;
            this.numara.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.numara.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.numara.BackColor = System.Drawing.Color.Transparent;
            this.numara.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("numara.BackgroundImage")));
            this.numara.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.numara.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.numara.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.numara.BorderColorIdle = System.Drawing.Color.Silver;
            this.numara.BorderRadius = 1;
            this.numara.BorderThickness = 1;
            this.numara.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.numara.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numara.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.numara.DefaultText = "";
            this.numara.FillColor = System.Drawing.Color.White;
            this.numara.HideSelection = true;
            this.numara.IconLeft = null;
            this.numara.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.numara.IconPadding = 10;
            this.numara.IconRight = null;
            this.numara.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.numara.Lines = new string[0];
            this.numara.Location = new System.Drawing.Point(532, 182);
            this.numara.Margin = new System.Windows.Forms.Padding(4);
            this.numara.MaxLength = 32767;
            this.numara.MinimumSize = new System.Drawing.Size(1, 1);
            this.numara.Modified = false;
            this.numara.Multiline = false;
            this.numara.Name = "numara";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.numara.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.numara.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.numara.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.numara.OnIdleState = stateProperties8;
            this.numara.Padding = new System.Windows.Forms.Padding(4);
            this.numara.PasswordChar = '\0';
            this.numara.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.numara.PlaceholderText = "Öğrenci Numarası";
            this.numara.ReadOnly = false;
            this.numara.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.numara.SelectedText = "";
            this.numara.SelectionLength = 0;
            this.numara.SelectionStart = 0;
            this.numara.ShortcutsEnabled = true;
            this.numara.Size = new System.Drawing.Size(347, 46);
            this.numara.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.numara.TabIndex = 1;
            this.numara.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.numara.TextMarginBottom = 0;
            this.numara.TextMarginLeft = 3;
            this.numara.TextMarginTop = 0;
            this.numara.TextPlaceholder = "Öğrenci Numarası";
            this.numara.UseSystemPasswordChar = false;
            this.numara.WordWrap = true;
            this.numara.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numara_KeyPress);
            // 
            // sifre
            // 
            this.sifre.AcceptsReturn = false;
            this.sifre.AcceptsTab = false;
            this.sifre.AnimationSpeed = 200;
            this.sifre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.sifre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.sifre.BackColor = System.Drawing.Color.Transparent;
            this.sifre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sifre.BackgroundImage")));
            this.sifre.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.sifre.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.sifre.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.sifre.BorderColorIdle = System.Drawing.Color.Silver;
            this.sifre.BorderRadius = 1;
            this.sifre.BorderThickness = 1;
            this.sifre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sifre.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.sifre.DefaultText = "";
            this.sifre.FillColor = System.Drawing.Color.White;
            this.sifre.HideSelection = true;
            this.sifre.IconLeft = null;
            this.sifre.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.sifre.IconPadding = 10;
            this.sifre.IconRight = null;
            this.sifre.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.sifre.Lines = new string[0];
            this.sifre.Location = new System.Drawing.Point(532, 267);
            this.sifre.Margin = new System.Windows.Forms.Padding(4);
            this.sifre.MaxLength = 32767;
            this.sifre.MinimumSize = new System.Drawing.Size(1, 1);
            this.sifre.Modified = false;
            this.sifre.Multiline = false;
            this.sifre.Name = "sifre";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.sifre.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.sifre.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.sifre.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.sifre.OnIdleState = stateProperties4;
            this.sifre.Padding = new System.Windows.Forms.Padding(4);
            this.sifre.PasswordChar = '\0';
            this.sifre.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.sifre.PlaceholderText = "Şifre";
            this.sifre.ReadOnly = false;
            this.sifre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sifre.SelectedText = "";
            this.sifre.SelectionLength = 0;
            this.sifre.SelectionStart = 0;
            this.sifre.ShortcutsEnabled = true;
            this.sifre.Size = new System.Drawing.Size(347, 46);
            this.sifre.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.sifre.TabIndex = 2;
            this.sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.sifre.TextMarginBottom = 0;
            this.sifre.TextMarginLeft = 3;
            this.sifre.TextMarginTop = 0;
            this.sifre.TextPlaceholder = "Şifre";
            this.sifre.UseSystemPasswordChar = false;
            this.sifre.WordWrap = true;
            this.sifre.TextChanged += new System.EventHandler(this.sifre_TextChanged);
            // 
            // girisYap
            // 
            this.girisYap.ActiveBorderThickness = 1;
            this.girisYap.ActiveCornerRadius = 20;
            this.girisYap.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.girisYap.ActiveForecolor = System.Drawing.Color.Transparent;
            this.girisYap.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.girisYap.BackColor = System.Drawing.SystemColors.Control;
            this.girisYap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("girisYap.BackgroundImage")));
            this.girisYap.ButtonText = "GİRİŞ";
            this.girisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.girisYap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.girisYap.ForeColor = System.Drawing.Color.Teal;
            this.girisYap.IdleBorderThickness = 1;
            this.girisYap.IdleCornerRadius = 20;
            this.girisYap.IdleFillColor = System.Drawing.Color.White;
            this.girisYap.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.girisYap.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.girisYap.Location = new System.Drawing.Point(585, 332);
            this.girisYap.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.girisYap.Name = "girisYap";
            this.girisYap.Size = new System.Drawing.Size(241, 50);
            this.girisYap.TabIndex = 3;
            this.girisYap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.girisYap.Click += new System.EventHandler(this.girisYap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(461, 182);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(461, 267);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.ActiveImage = null;
            this.bunifuImageButton2.AllowAnimations = true;
            this.bunifuImageButton2.AllowBuffering = false;
            this.bunifuImageButton2.AllowToggling = false;
            this.bunifuImageButton2.AllowZooming = true;
            this.bunifuImageButton2.AllowZoomingOnFocus = false;
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ErrorImage")));
            this.bunifuImageButton2.FadeWhenInactive = false;
            this.bunifuImageButton2.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.ImageLocation = null;
            this.bunifuImageButton2.ImageMargin = 0;
            this.bunifuImageButton2.ImageSize = new System.Drawing.Size(46, 46);
            this.bunifuImageButton2.ImageZoomSize = new System.Drawing.Size(47, 47);
            this.bunifuImageButton2.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.InitialImage")));
            this.bunifuImageButton2.Location = new System.Drawing.Point(1013, 5);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Rotation = 0;
            this.bunifuImageButton2.ShowActiveImage = true;
            this.bunifuImageButton2.ShowCursorChanges = true;
            this.bunifuImageButton2.ShowImageBorders = true;
            this.bunifuImageButton2.ShowSizeMarkers = false;
            this.bunifuImageButton2.Size = new System.Drawing.Size(47, 47);
            this.bunifuImageButton2.TabIndex = 7;
            this.bunifuImageButton2.ToolTipText = "";
            this.bunifuImageButton2.WaitOnLoad = false;
            this.bunifuImageButton2.Zoom = 0;
            this.bunifuImageButton2.ZoomSpeed = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.ActiveImage = null;
            this.bunifuImageButton3.AllowAnimations = true;
            this.bunifuImageButton3.AllowBuffering = false;
            this.bunifuImageButton3.AllowToggling = false;
            this.bunifuImageButton3.AllowZooming = true;
            this.bunifuImageButton3.AllowZoomingOnFocus = false;
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.ErrorImage")));
            this.bunifuImageButton3.FadeWhenInactive = false;
            this.bunifuImageButton3.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.ImageLocation = null;
            this.bunifuImageButton3.ImageMargin = 0;
            this.bunifuImageButton3.ImageSize = new System.Drawing.Size(46, 46);
            this.bunifuImageButton3.ImageZoomSize = new System.Drawing.Size(47, 47);
            this.bunifuImageButton3.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.InitialImage")));
            this.bunifuImageButton3.Location = new System.Drawing.Point(959, 5);
            this.bunifuImageButton3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Rotation = 0;
            this.bunifuImageButton3.ShowActiveImage = true;
            this.bunifuImageButton3.ShowCursorChanges = true;
            this.bunifuImageButton3.ShowImageBorders = true;
            this.bunifuImageButton3.ShowSizeMarkers = false;
            this.bunifuImageButton3.Size = new System.Drawing.Size(47, 47);
            this.bunifuImageButton3.TabIndex = 8;
            this.bunifuImageButton3.ToolTipText = "";
            this.bunifuImageButton3.WaitOnLoad = false;
            this.bunifuImageButton3.Zoom = 0;
            this.bunifuImageButton3.ZoomSpeed = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuCircleProgress1
            // 
            this.bunifuCircleProgress1.Animated = false;
            this.bunifuCircleProgress1.AnimationInterval = 1;
            this.bunifuCircleProgress1.AnimationSpeed = 1;
            this.bunifuCircleProgress1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgress1.CircleMargin = 10;
            this.bunifuCircleProgress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.bunifuCircleProgress1.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgress1.IsPercentage = false;
            this.bunifuCircleProgress1.LineProgressThickness = 4;
            this.bunifuCircleProgress1.LineThickness = 3;
            this.bunifuCircleProgress1.Location = new System.Drawing.Point(675, 449);
            this.bunifuCircleProgress1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuCircleProgress1.Name = "bunifuCircleProgress1";
            this.bunifuCircleProgress1.ProgressAnimationSpeed = 200;
            this.bunifuCircleProgress1.ProgressBackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgress1.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.bunifuCircleProgress1.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.bunifuCircleProgress1.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.bunifuCircleProgress1.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.bunifuCircleProgress1.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.bunifuCircleProgress1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.bunifuCircleProgress1.Size = new System.Drawing.Size(64, 64);
            this.bunifuCircleProgress1.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bunifuCircleProgress1.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.bunifuCircleProgress1.SubScriptText = "";
            this.bunifuCircleProgress1.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.bunifuCircleProgress1.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.bunifuCircleProgress1.SuperScriptText = "";
            this.bunifuCircleProgress1.TabIndex = 16;
            this.bunifuCircleProgress1.Text = "30";
            this.bunifuCircleProgress1.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.bunifuCircleProgress1.Value = 30;
            this.bunifuCircleProgress1.ValueByTransition = 30;
            this.bunifuCircleProgress1.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuLabel2.Location = new System.Drawing.Point(461, 84);
            this.bunifuLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(0, 0);
            this.bunifuLabel2.TabIndex = 17;
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // geriGetir
            // 
            this.geriGetir.ActiveBorderThickness = 1;
            this.geriGetir.ActiveCornerRadius = 20;
            this.geriGetir.ActiveFillColor = System.Drawing.Color.DeepSkyBlue;
            this.geriGetir.ActiveForecolor = System.Drawing.Color.Transparent;
            this.geriGetir.ActiveLineColor = System.Drawing.Color.DeepSkyBlue;
            this.geriGetir.BackColor = System.Drawing.SystemColors.Control;
            this.geriGetir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("geriGetir.BackgroundImage")));
            this.geriGetir.ButtonText = "SON KULLANICI VERİLERİNİ GETİR";
            this.geriGetir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.geriGetir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.geriGetir.ForeColor = System.Drawing.Color.Teal;
            this.geriGetir.IdleBorderThickness = 1;
            this.geriGetir.IdleCornerRadius = 20;
            this.geriGetir.IdleFillColor = System.Drawing.Color.White;
            this.geriGetir.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.geriGetir.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.geriGetir.Location = new System.Drawing.Point(520, 390);
            this.geriGetir.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.geriGetir.Name = "geriGetir";
            this.geriGetir.Size = new System.Drawing.Size(373, 50);
            this.geriGetir.TabIndex = 19;
            this.geriGetir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.geriGetir.Click += new System.EventHandler(this.geriGetir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(650, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 49);
            this.label1.TabIndex = 20;
            this.label1.Text = "Giriş";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.geriGetir);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuCircleProgress1);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.girisYap);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.numara);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuThinButton2 girisYap;
        private Bunifu.UI.WinForms.BunifuTextBox sifre;
        private Bunifu.UI.WinForms.BunifuTextBox numara;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton2;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton3;
        private Bunifu.UI.WinForms.BunifuCircleProgress bunifuCircleProgress1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.Framework.UI.BunifuThinButton2 geriGetir;
        private System.Windows.Forms.Label label1;
    }
}

