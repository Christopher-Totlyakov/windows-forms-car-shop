namespace Курсова_работа_на_Кристофър_Тотляков
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            gridTransition = new System.Windows.Forms.Timer(components);
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            gridButten2 = new PictureBox();
            gridButten1 = new PictureBox();
            topBar = new Panel();
            carLogopictureBox = new PictureBox();
            loadedDataButton = new Button();
            buttonSave = new Button();
            gridLabal = new Label();
            carListBox = new ListBox();
            filterFindButton = new Button();
            yearsTextBox = new TextBox();
            brandTextBox = new TextBox();
            modelTextBox = new TextBox();
            yearsLabel = new Label();
            brandLabel = new Label();
            modelLabel = new Label();
            carFilterlabel = new Label();
            panel1 = new Panel();
            filterHorsepowerButton = new Button();
            filterButton = new Button();
            titleLabel1 = new Label();
            titleLabel2 = new Label();
            brandHorsepowerTextBox = new TextBox();
            minHorsepowerTextBox = new TextBox();
            brandHorsepowerlabel = new Label();
            horsepowerLabel = new Label();
            maxHorsepowerTextBox = new TextBox();
            minHorsepowerLabel = new Label();
            maxHorsepowerLabel = new Label();
            filterByHorsepowerlabelTitle = new Label();
            findHorsepowerbutton = new Button();
            horsepowerlistBox = new ListBox();
            tirePictureBox = new PictureBox();
            carPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridButten2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridButten1).BeginInit();
            topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)carLogopictureBox).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tirePictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carPictureBox).BeginInit();
            SuspendLayout();
            // 
            // gridTransition
            // 
            gridTransition.Tick += gridTransiton_Tick;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.Blue;
            dataGridViewCellStyle1.ForeColor = Color.Lavender;
            dataGridViewCellStyle1.SelectionBackColor = Color.Violet;
            dataGridViewCellStyle1.SelectionForeColor = Color.Yellow;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.LightSkyBlue;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.Info;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Info;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.GridColor = Color.LightSkyBlue;
            dataGridView1.Location = new Point(138, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.ForeColor = Color.Yellow;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(255, 128, 255);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(520, 274);
            dataGridView1.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "Registration.№";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Brand";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Model";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Year of manufacture";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "horsepower";
            Column5.Name = "Column5";
            // 
            // gridButten2
            // 
            gridButten2.Cursor = Cursors.Hand;
            gridButten2.Image = (Image)resources.GetObject("gridButten2.Image");
            gridButten2.Location = new Point(3, 304);
            gridButten2.Name = "gridButten2";
            gridButten2.Size = new Size(40, 34);
            gridButten2.SizeMode = PictureBoxSizeMode.StretchImage;
            gridButten2.TabIndex = 3;
            gridButten2.TabStop = false;
            gridButten2.Click += gridButten2_Click;
            // 
            // gridButten1
            // 
            gridButten1.Cursor = Cursors.Hand;
            gridButten1.Image = (Image)resources.GetObject("gridButten1.Image");
            gridButten1.Location = new Point(3, 3);
            gridButten1.Name = "gridButten1";
            gridButten1.Size = new Size(40, 34);
            gridButten1.SizeMode = PictureBoxSizeMode.StretchImage;
            gridButten1.TabIndex = 1;
            gridButten1.TabStop = false;
            gridButten1.Click += gridButten_Click;
            // 
            // topBar
            // 
            topBar.BackColor = Color.LightSkyBlue;
            topBar.Controls.Add(carLogopictureBox);
            topBar.Controls.Add(loadedDataButton);
            topBar.Controls.Add(buttonSave);
            topBar.Controls.Add(gridLabal);
            topBar.Controls.Add(dataGridView1);
            topBar.Controls.Add(gridButten1);
            topBar.Controls.Add(gridButten2);
            topBar.Dock = DockStyle.Top;
            topBar.Location = new Point(0, 0);
            topBar.Name = "topBar";
            topBar.Size = new Size(800, 41);
            topBar.TabIndex = 5;
            // 
            // carLogopictureBox
            // 
            carLogopictureBox.BackColor = Color.LightSkyBlue;
            carLogopictureBox.Image = (Image)resources.GetObject("carLogopictureBox.Image");
            carLogopictureBox.Location = new Point(178, 128);
            carLogopictureBox.Name = "carLogopictureBox";
            carLogopictureBox.Size = new Size(395, 176);
            carLogopictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            carLogopictureBox.TabIndex = 28;
            carLogopictureBox.TabStop = false;
            // 
            // loadedDataButton
            // 
            loadedDataButton.BackColor = Color.DeepSkyBlue;
            loadedDataButton.FlatStyle = FlatStyle.Popup;
            loadedDataButton.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loadedDataButton.Location = new Point(308, 56);
            loadedDataButton.Name = "loadedDataButton";
            loadedDataButton.Size = new Size(135, 42);
            loadedDataButton.TabIndex = 10;
            loadedDataButton.Text = "loaded DATA";
            loadedDataButton.UseVisualStyleBackColor = false;
            loadedDataButton.Click += loadedDataButton_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.DeepSkyBlue;
            buttonSave.FlatStyle = FlatStyle.Popup;
            buttonSave.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Location = new Point(685, 143);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(86, 34);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // gridLabal
            // 
            gridLabal.AutoSize = true;
            gridLabal.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            gridLabal.Location = new Point(49, 9);
            gridLabal.Name = "gridLabal";
            gridLabal.Size = new Size(159, 23);
            gridLabal.TabIndex = 5;
            gridLabal.Text = "DATA from File";
            gridLabal.Click += gridLabal_Click;
            // 
            // carListBox
            // 
            carListBox.BackColor = SystemColors.HotTrack;
            carListBox.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            carListBox.ForeColor = SystemColors.Menu;
            carListBox.FormattingEnabled = true;
            carListBox.ItemHeight = 17;
            carListBox.Location = new Point(528, 186);
            carListBox.Name = "carListBox";
            carListBox.Size = new Size(117, 123);
            carListBox.TabIndex = 6;
            // 
            // filterFindButton
            // 
            filterFindButton.BackColor = Color.DeepSkyBlue;
            filterFindButton.Cursor = Cursors.Hand;
            filterFindButton.FlatStyle = FlatStyle.Popup;
            filterFindButton.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            filterFindButton.Location = new Point(398, 221);
            filterFindButton.Name = "filterFindButton";
            filterFindButton.Size = new Size(89, 35);
            filterFindButton.TabIndex = 7;
            filterFindButton.Text = "Find";
            filterFindButton.UseVisualStyleBackColor = false;
            filterFindButton.Click += filterFindButton_Click;
            // 
            // yearsTextBox
            // 
            yearsTextBox.BackColor = SystemColors.HotTrack;
            yearsTextBox.BorderStyle = BorderStyle.FixedSingle;
            yearsTextBox.Cursor = Cursors.IBeam;
            yearsTextBox.ForeColor = SystemColors.Window;
            yearsTextBox.Location = new Point(246, 165);
            yearsTextBox.Name = "yearsTextBox";
            yearsTextBox.Size = new Size(100, 23);
            yearsTextBox.TabIndex = 8;
            // 
            // brandTextBox
            // 
            brandTextBox.BackColor = SystemColors.HotTrack;
            brandTextBox.BorderStyle = BorderStyle.FixedSingle;
            brandTextBox.Cursor = Cursors.IBeam;
            brandTextBox.ForeColor = SystemColors.Window;
            brandTextBox.Location = new Point(246, 221);
            brandTextBox.Name = "brandTextBox";
            brandTextBox.Size = new Size(100, 23);
            brandTextBox.TabIndex = 9;
            // 
            // modelTextBox
            // 
            modelTextBox.BackColor = SystemColors.HotTrack;
            modelTextBox.BorderStyle = BorderStyle.FixedSingle;
            modelTextBox.Cursor = Cursors.IBeam;
            modelTextBox.ForeColor = SystemColors.Window;
            modelTextBox.Location = new Point(246, 278);
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(100, 23);
            modelTextBox.TabIndex = 10;
            // 
            // yearsLabel
            // 
            yearsLabel.AutoSize = true;
            yearsLabel.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            yearsLabel.Location = new Point(47, 166);
            yearsLabel.Name = "yearsLabel";
            yearsLabel.Size = new Size(193, 23);
            yearsLabel.TabIndex = 11;
            yearsLabel.Text = "Minimum car year:";
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            brandLabel.Location = new Point(160, 221);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(80, 23);
            brandLabel.TabIndex = 12;
            brandLabel.Text = "Brand:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            modelLabel.Location = new Point(160, 278);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(80, 23);
            modelLabel.TabIndex = 13;
            modelLabel.Text = "Model:";
            // 
            // carFilterlabel
            // 
            carFilterlabel.AutoSize = true;
            carFilterlabel.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            carFilterlabel.Location = new Point(49, 89);
            carFilterlabel.Name = "carFilterlabel";
            carFilterlabel.Size = new Size(174, 36);
            carFilterlabel.TabIndex = 14;
            carFilterlabel.Text = "car filter";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(filterHorsepowerButton);
            panel1.Controls.Add(filterButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 405);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 45);
            panel1.TabIndex = 15;
            // 
            // filterHorsepowerButton
            // 
            filterHorsepowerButton.BackColor = Color.DeepSkyBlue;
            filterHorsepowerButton.Cursor = Cursors.Hand;
            filterHorsepowerButton.FlatStyle = FlatStyle.Popup;
            filterHorsepowerButton.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            filterHorsepowerButton.ImageAlign = ContentAlignment.BottomCenter;
            filterHorsepowerButton.Location = new Point(528, 0);
            filterHorsepowerButton.Margin = new Padding(0);
            filterHorsepowerButton.Name = "filterHorsepowerButton";
            filterHorsepowerButton.Size = new Size(272, 45);
            filterHorsepowerButton.TabIndex = 18;
            filterHorsepowerButton.Text = "Filter by horsepower ";
            filterHorsepowerButton.UseVisualStyleBackColor = false;
            filterHorsepowerButton.Click += filterHorsepowerButton_Click;
            // 
            // filterButton
            // 
            filterButton.BackColor = Color.DeepSkyBlue;
            filterButton.Cursor = Cursors.Hand;
            filterButton.FlatStyle = FlatStyle.Popup;
            filterButton.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            filterButton.ImageAlign = ContentAlignment.BottomCenter;
            filterButton.Location = new Point(0, 0);
            filterButton.Margin = new Padding(0);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(272, 45);
            filterButton.TabIndex = 16;
            filterButton.Text = "Filter by brand/model";
            filterButton.UseVisualStyleBackColor = false;
            filterButton.Click += filterButton_Click;
            // 
            // titleLabel1
            // 
            titleLabel1.AutoSize = true;
            titleLabel1.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            titleLabel1.Location = new Point(218, 99);
            titleLabel1.Name = "titleLabel1";
            titleLabel1.Size = new Size(323, 40);
            titleLabel1.TabIndex = 16;
            titleLabel1.Text = "Welcome in ours ";
            // 
            // titleLabel2
            // 
            titleLabel2.AutoSize = true;
            titleLabel2.Font = new Font("Showcard Gothic", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            titleLabel2.Location = new Point(419, 143);
            titleLabel2.Name = "titleLabel2";
            titleLabel2.Size = new Size(331, 40);
            titleLabel2.TabIndex = 17;
            titleLabel2.Text = "car data storage";
            // 
            // brandHorsepowerTextBox
            // 
            brandHorsepowerTextBox.BackColor = SystemColors.HotTrack;
            brandHorsepowerTextBox.BorderStyle = BorderStyle.FixedSingle;
            brandHorsepowerTextBox.ForeColor = SystemColors.Window;
            brandHorsepowerTextBox.Location = new Point(171, 192);
            brandHorsepowerTextBox.Name = "brandHorsepowerTextBox";
            brandHorsepowerTextBox.Size = new Size(100, 23);
            brandHorsepowerTextBox.TabIndex = 18;
            // 
            // minHorsepowerTextBox
            // 
            minHorsepowerTextBox.BackColor = SystemColors.HotTrack;
            minHorsepowerTextBox.BorderStyle = BorderStyle.FixedSingle;
            minHorsepowerTextBox.ForeColor = SystemColors.Window;
            minHorsepowerTextBox.Location = new Point(179, 256);
            minHorsepowerTextBox.Name = "minHorsepowerTextBox";
            minHorsepowerTextBox.Size = new Size(31, 23);
            minHorsepowerTextBox.TabIndex = 19;
            // 
            // brandHorsepowerlabel
            // 
            brandHorsepowerlabel.AutoSize = true;
            brandHorsepowerlabel.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            brandHorsepowerlabel.Location = new Point(85, 192);
            brandHorsepowerlabel.Name = "brandHorsepowerlabel";
            brandHorsepowerlabel.Size = new Size(80, 23);
            brandHorsepowerlabel.TabIndex = 20;
            brandHorsepowerlabel.Text = "brand:";
            // 
            // horsepowerLabel
            // 
            horsepowerLabel.AutoSize = true;
            horsepowerLabel.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            horsepowerLabel.Location = new Point(15, 256);
            horsepowerLabel.Name = "horsepowerLabel";
            horsepowerLabel.Size = new Size(150, 23);
            horsepowerLabel.TabIndex = 21;
            horsepowerLabel.Text = "horsepower:";
            // 
            // maxHorsepowerTextBox
            // 
            maxHorsepowerTextBox.BackColor = SystemColors.HotTrack;
            maxHorsepowerTextBox.BorderStyle = BorderStyle.FixedSingle;
            maxHorsepowerTextBox.ForeColor = SystemColors.Window;
            maxHorsepowerTextBox.Location = new Point(233, 256);
            maxHorsepowerTextBox.Name = "maxHorsepowerTextBox";
            maxHorsepowerTextBox.Size = new Size(31, 23);
            maxHorsepowerTextBox.TabIndex = 22;
            // 
            // minHorsepowerLabel
            // 
            minHorsepowerLabel.AutoSize = true;
            minHorsepowerLabel.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            minHorsepowerLabel.Location = new Point(171, 230);
            minHorsepowerLabel.Name = "minHorsepowerLabel";
            minHorsepowerLabel.Size = new Size(44, 23);
            minHorsepowerLabel.TabIndex = 23;
            minHorsepowerLabel.Text = "min";
            // 
            // maxHorsepowerLabel
            // 
            maxHorsepowerLabel.AutoSize = true;
            maxHorsepowerLabel.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            maxHorsepowerLabel.Location = new Point(221, 230);
            maxHorsepowerLabel.Name = "maxHorsepowerLabel";
            maxHorsepowerLabel.Size = new Size(51, 23);
            maxHorsepowerLabel.TabIndex = 24;
            maxHorsepowerLabel.Text = "max";
            // 
            // filterByHorsepowerlabelTitle
            // 
            filterByHorsepowerlabelTitle.AutoSize = true;
            filterByHorsepowerlabelTitle.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            filterByHorsepowerlabelTitle.Location = new Point(21, 89);
            filterByHorsepowerlabelTitle.Name = "filterByHorsepowerlabelTitle";
            filterByHorsepowerlabelTitle.Size = new Size(373, 36);
            filterByHorsepowerlabelTitle.TabIndex = 25;
            filterByHorsepowerlabelTitle.Text = "Filter by horsepower ";
            // 
            // findHorsepowerbutton
            // 
            findHorsepowerbutton.BackColor = Color.DeepSkyBlue;
            findHorsepowerbutton.Cursor = Cursors.Hand;
            findHorsepowerbutton.FlatStyle = FlatStyle.Popup;
            findHorsepowerbutton.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            findHorsepowerbutton.Location = new Point(334, 224);
            findHorsepowerbutton.Name = "findHorsepowerbutton";
            findHorsepowerbutton.Size = new Size(89, 35);
            findHorsepowerbutton.TabIndex = 26;
            findHorsepowerbutton.Text = "Find";
            findHorsepowerbutton.UseVisualStyleBackColor = false;
            findHorsepowerbutton.Click += findHorsepowerbutton_Click;
            // 
            // horsepowerlistBox
            // 
            horsepowerlistBox.BackColor = SystemColors.HotTrack;
            horsepowerlistBox.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            horsepowerlistBox.ForeColor = SystemColors.Menu;
            horsepowerlistBox.FormattingEnabled = true;
            horsepowerlistBox.ItemHeight = 17;
            horsepowerlistBox.Location = new Point(465, 186);
            horsepowerlistBox.Name = "horsepowerlistBox";
            horsepowerlistBox.Size = new Size(129, 123);
            horsepowerlistBox.TabIndex = 27;
            // 
            // tirePictureBox
            // 
            tirePictureBox.Image = (Image)resources.GetObject("tirePictureBox.Image");
            tirePictureBox.Location = new Point(0, 165);
            tirePictureBox.Name = "tirePictureBox";
            tirePictureBox.Size = new Size(403, 240);
            tirePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            tirePictureBox.TabIndex = 28;
            tirePictureBox.TabStop = false;
            // 
            // carPictureBox
            // 
            carPictureBox.Image = (Image)resources.GetObject("carPictureBox.Image");
            carPictureBox.Location = new Point(416, 45);
            carPictureBox.Name = "carPictureBox";
            carPictureBox.Size = new Size(384, 199);
            carPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            carPictureBox.TabIndex = 29;
            carPictureBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCyan;
            ClientSize = new Size(800, 450);
            Controls.Add(horsepowerlistBox);
            Controls.Add(findHorsepowerbutton);
            Controls.Add(filterByHorsepowerlabelTitle);
            Controls.Add(maxHorsepowerLabel);
            Controls.Add(minHorsepowerLabel);
            Controls.Add(maxHorsepowerTextBox);
            Controls.Add(horsepowerLabel);
            Controls.Add(brandHorsepowerlabel);
            Controls.Add(minHorsepowerTextBox);
            Controls.Add(brandHorsepowerTextBox);
            Controls.Add(titleLabel2);
            Controls.Add(titleLabel1);
            Controls.Add(panel1);
            Controls.Add(carFilterlabel);
            Controls.Add(modelLabel);
            Controls.Add(brandLabel);
            Controls.Add(yearsLabel);
            Controls.Add(modelTextBox);
            Controls.Add(brandTextBox);
            Controls.Add(yearsTextBox);
            Controls.Add(filterFindButton);
            Controls.Add(carListBox);
            Controls.Add(topBar);
            Controls.Add(carPictureBox);
            Controls.Add(tirePictureBox);
            Name = "Form1";
            Text = "Windows Forms Car shop";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridButten2).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridButten1).EndInit();
            topBar.ResumeLayout(false);
            topBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)carLogopictureBox).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tirePictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)carPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer gridTransition;
        private DataGridView dataGridView1;
        private PictureBox gridButten2;
        private PictureBox gridButten1;
        private Panel topBar;
        private Label gridLabal;
        private Button buttonSave;
        private Button loadedDataButton;
        private ListBox carListBox;
        private Button filterFindButton;
        private TextBox yearsTextBox;
        private TextBox brandTextBox;
        private TextBox modelTextBox;
        private Label yearsLabel;
        private Label brandLabel;
        private Label modelLabel;
        private Label carFilterlabel;
        private Panel panel1;
        public Button filterButton;
        private Label titleLabel1;
        private Label titleLabel2;
        public Button filterHorsepowerButton;
        private TextBox brandHorsepowerTextBox;
        private TextBox minHorsepowerTextBox;
        private Label brandHorsepowerlabel;
        private Label horsepowerLabel;
        private TextBox maxHorsepowerTextBox;
        private Label minHorsepowerLabel;
        private Label maxHorsepowerLabel;
        private Label filterByHorsepowerlabelTitle;
        private Button findHorsepowerbutton;
        private ListBox horsepowerlistBox;
        private PictureBox carLogopictureBox;
        private PictureBox tirePictureBox;
        private PictureBox carPictureBox;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
