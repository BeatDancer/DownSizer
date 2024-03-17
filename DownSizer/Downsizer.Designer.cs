namespace DownSizer
{
    partial class Downsizer
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            ChooseImage = new Button();
            PictureTLP = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            procenti = new TextBox();
            DownsizeImage = new Button();
            pictureBox = new PictureBox();
            PictureTLP.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // ChooseImage
            // 
            ChooseImage.Dock = DockStyle.Fill;
            ChooseImage.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ChooseImage.Location = new Point(3, 3);
            ChooseImage.Name = "ChooseImage";
            ChooseImage.Size = new Size(230, 77);
            ChooseImage.TabIndex = 0;
            ChooseImage.Text = "Избери снимка";
            ChooseImage.UseVisualStyleBackColor = true;
            ChooseImage.Click += ChooseImage_Click;
            // 
            // PictureTLP
            // 
            PictureTLP.ColumnCount = 1;
            PictureTLP.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            PictureTLP.Controls.Add(tableLayoutPanel1, 0, 1);
            PictureTLP.Controls.Add(pictureBox, 0, 0);
            PictureTLP.Dock = DockStyle.Fill;
            PictureTLP.Location = new Point(0, 0);
            PictureTLP.Name = "PictureTLP";
            PictureTLP.RowCount = 2;
            PictureTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            PictureTLP.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            PictureTLP.Size = new Size(715, 445);
            PictureTLP.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(ChooseImage, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(DownsizeImage, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 359);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(709, 83);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(procenti, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(239, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(230, 77);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 38);
            label1.TabIndex = 0;
            label1.Text = "Избери проценти";
            // 
            // procenti
            // 
            procenti.Dock = DockStyle.Fill;
            procenti.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            procenti.Location = new Point(3, 41);
            procenti.Name = "procenti";
            procenti.Size = new Size(224, 51);
            procenti.TabIndex = 1;
            // 
            // DownsizeImage
            // 
            DownsizeImage.Dock = DockStyle.Fill;
            DownsizeImage.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            DownsizeImage.Location = new Point(475, 3);
            DownsizeImage.Name = "DownsizeImage";
            DownsizeImage.Size = new Size(231, 77);
            DownsizeImage.TabIndex = 2;
            DownsizeImage.Text = "Запази";
            DownsizeImage.UseVisualStyleBackColor = true;
            DownsizeImage.Click += DownsizeImage_Click;
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(3, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(709, 350);
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            // 
            // Downsizer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(715, 445);
            Controls.Add(PictureTLP);
            Name = "Downsizer";
            Text = "Downsizer";
            PictureTLP.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox selectedImagePathTextBox;
        private TextBox Height;
        private Button ChooseImage;
        private TableLayoutPanel PictureTLP;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private TextBox procenti;
        private Button DownsizeImage;
        private PictureBox pictureBox;
    }
}
