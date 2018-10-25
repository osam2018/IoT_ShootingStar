namespace ControlTower
{
    partial class ControlTower
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.shootingStatusLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.shootingStatusImgRed = new System.Windows.Forms.PictureBox();
            this.shootingCountLbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.shootingTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.shootingStatusImgGreen = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shootingStatusImgRed)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shootingStatusImgGreen)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(60, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "1사로";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(250, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "ShootingStar Control Tower";
            // 
            // shootingStatusLbl
            // 
            this.shootingStatusLbl.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.shootingStatusLbl.ForeColor = System.Drawing.Color.Red;
            this.shootingStatusLbl.Location = new System.Drawing.Point(51, 270);
            this.shootingStatusLbl.Name = "shootingStatusLbl";
            this.shootingStatusLbl.Size = new System.Drawing.Size(133, 32);
            this.shootingStatusLbl.TabIndex = 4;
            this.shootingStatusLbl.Text = "사격 중";
            this.shootingStatusLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.shootingStatusImgGreen);
            this.groupBox1.Controls.Add(this.shootingStatusImgRed);
            this.groupBox1.Controls.Add(this.shootingCountLbl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.shootingStatusLbl);
            this.groupBox1.Location = new System.Drawing.Point(37, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(199, 325);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // shootingStatusImgRed
            // 
            this.shootingStatusImgRed.Image = global::ControlTower.Properties.Resources.shooting;
            this.shootingStatusImgRed.Location = new System.Drawing.Point(26, 279);
            this.shootingStatusImgRed.Name = "shootingStatusImgRed";
            this.shootingStatusImgRed.Size = new System.Drawing.Size(18, 19);
            this.shootingStatusImgRed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shootingStatusImgRed.TabIndex = 9;
            this.shootingStatusImgRed.TabStop = false;
            // 
            // shootingCountLbl
            // 
            this.shootingCountLbl.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.shootingCountLbl.Location = new System.Drawing.Point(16, 131);
            this.shootingCountLbl.Name = "shootingCountLbl";
            this.shootingCountLbl.Size = new System.Drawing.Size(169, 32);
            this.shootingCountLbl.TabIndex = 6;
            this.shootingCountLbl.Text = "0 / 20";
            this.shootingCountLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(306, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 325);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ControlTower.Properties.Resources.wait;
            this.pictureBox2.Location = new System.Drawing.Point(28, 279);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(18, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(16, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "0 / 20";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(60, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "2사로";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(55, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "사격 준비";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(560, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 325);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ControlTower.Properties.Resources.wait;
            this.pictureBox3.Location = new System.Drawing.Point(24, 280);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(18, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(55, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 32);
            this.label10.TabIndex = 9;
            this.label10.Text = "사격 준비";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(16, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 32);
            this.label8.TabIndex = 6;
            this.label8.Text = "0 / 20";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(60, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 32);
            this.label9.TabIndex = 3;
            this.label9.Text = "3사로";
            // 
            // shootingTimer
            // 
            this.shootingTimer.Enabled = true;
            this.shootingTimer.Interval = 1000;
            this.shootingTimer.Tick += new System.EventHandler(this.shootingTimer_Tick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ControlTower.Properties.Resources.bluetooth;
            this.pictureBox4.Location = new System.Drawing.Point(211, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // shootingStatusImgGreen
            // 
            this.shootingStatusImgGreen.Image = global::ControlTower.Properties.Resources.complete;
            this.shootingStatusImgGreen.Location = new System.Drawing.Point(26, 279);
            this.shootingStatusImgGreen.Name = "shootingStatusImgGreen";
            this.shootingStatusImgGreen.Size = new System.Drawing.Size(18, 19);
            this.shootingStatusImgGreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.shootingStatusImgGreen.TabIndex = 10;
            this.shootingStatusImgGreen.TabStop = false;
            this.shootingStatusImgGreen.Visible = false;
            // 
            // ControlTower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ControlTower";
            this.ShowIcon = false;
            this.Text = "ControlTower";
            this.Load += new System.EventHandler(this.ControlTower_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shootingStatusImgRed)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shootingStatusImgGreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label shootingStatusLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox shootingStatusImgRed;
        private System.Windows.Forms.Label shootingCountLbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer shootingTimer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox shootingStatusImgGreen;
    }
}

