using System.Windows.Forms;

namespace SegbisUygulaması
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridAllPhones = new System.Windows.Forms.DataGridView();
            this.ciscoC60Label = new System.Windows.Forms.Label();
            this.ciscoEX90Label = new System.Windows.Forms.Label();
            this.ciscoMX200Label = new System.Windows.Forms.Label();
            this.ciscoSX20Label = new System.Windows.Forms.Label();
            this.ciscoSX80Label = new System.Windows.Forms.Label();
            this.ciscoRoomKitProLabel = new System.Windows.Forms.Label();
            this.ciscoRoomKitMiniLabel = new System.Windows.Forms.Label();
            this.toplamLabel1 = new System.Windows.Forms.Label();
            this.roomKitEQLabel = new System.Windows.Forms.Label();
            this.roomBarLabel = new System.Windows.Forms.Label();
            this.bimLabel = new System.Windows.Forms.Label();
            this.bamLabel = new System.Windows.Forms.Label();
            this.savcilikLabel = new System.Windows.Forms.Label();
            this.cezaMahLabel = new System.Windows.Forms.Label();
            this.cikLabel = new System.Windows.Forms.Label();
            this.yuksekYargiLabel = new System.Windows.Forms.Label();
            this.gtLabel = new System.Windows.Forms.Label();
            this.agoLabel = new System.Windows.Forms.Label();
            this.hskLabel = new System.Windows.Forms.Label();
            this.toplamLabel2 = new System.Windows.Forms.Label();
            this.excelExportBtn = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.labelLoading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllPhones)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);

            // 
            // dataGridAllPhones
            // 
            this.dataGridAllPhones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridAllPhones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAllPhones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAllPhones.Location = new System.Drawing.Point(39, 185);
            this.dataGridAllPhones.Name = "dataGridAllPhones";
            this.dataGridAllPhones.Size = new System.Drawing.Size(1285, 445);
            this.dataGridAllPhones.TabIndex = 0;
            // 
            // ciscoC60Label
            // 
            this.ciscoC60Label.AutoSize = true;
            this.ciscoC60Label.Location = new System.Drawing.Point(36, 11);
            this.ciscoC60Label.Name = "ciscoC60Label";
            this.ciscoC60Label.Size = new System.Drawing.Size(58, 13);
            this.ciscoC60Label.TabIndex = 1;
            this.ciscoC60Label.Text = "Cisco C60:";
            // 
            // ciscoEX90Label
            // 
            this.ciscoEX90Label.AutoSize = true;
            this.ciscoEX90Label.Location = new System.Drawing.Point(200, 11);
            this.ciscoEX90Label.Name = "ciscoEX90Label";
            this.ciscoEX90Label.Size = new System.Drawing.Size(65, 13);
            this.ciscoEX90Label.TabIndex = 2;
            this.ciscoEX90Label.Text = "Cisco EX90:";
            // 
            // ciscoMX200Label
            // 
            this.ciscoMX200Label.AutoSize = true;
            this.ciscoMX200Label.Location = new System.Drawing.Point(200, 39);
            this.ciscoMX200Label.Name = "ciscoMX200Label";
            this.ciscoMX200Label.Size = new System.Drawing.Size(73, 13);
            this.ciscoMX200Label.TabIndex = 3;
            this.ciscoMX200Label.Text = "Cisco MX200:";
            // 
            // ciscoSX20Label
            // 
            this.ciscoSX20Label.AutoSize = true;
            this.ciscoSX20Label.Location = new System.Drawing.Point(36, 65);
            this.ciscoSX20Label.Name = "ciscoSX20Label";
            this.ciscoSX20Label.Size = new System.Drawing.Size(65, 13);
            this.ciscoSX20Label.TabIndex = 4;
            this.ciscoSX20Label.Text = "Cisco SX20:";
            // 
            // ciscoSX80Label
            // 
            this.ciscoSX80Label.AutoSize = true;
            this.ciscoSX80Label.Location = new System.Drawing.Point(36, 39);
            this.ciscoSX80Label.Name = "ciscoSX80Label";
            this.ciscoSX80Label.Size = new System.Drawing.Size(65, 13);
            this.ciscoSX80Label.TabIndex = 5;
            this.ciscoSX80Label.Text = "Cisco SX80:";
            // 
            // ciscoRoomKitProLabel
            // 
            this.ciscoRoomKitProLabel.AutoSize = true;
            this.ciscoRoomKitProLabel.Location = new System.Drawing.Point(36, 94);
            this.ciscoRoomKitProLabel.Name = "ciscoRoomKitProLabel";
            this.ciscoRoomKitProLabel.Size = new System.Drawing.Size(101, 13);
            this.ciscoRoomKitProLabel.TabIndex = 6;
            this.ciscoRoomKitProLabel.Text = "Cisco Room Kit Pro:";
            // 
            // ciscoRoomKitMiniLabel
            // 
            this.ciscoRoomKitMiniLabel.AutoSize = true;
            this.ciscoRoomKitMiniLabel.Location = new System.Drawing.Point(200, 65);
            this.ciscoRoomKitMiniLabel.Name = "ciscoRoomKitMiniLabel";
            this.ciscoRoomKitMiniLabel.Size = new System.Drawing.Size(104, 13);
            this.ciscoRoomKitMiniLabel.TabIndex = 7;
            this.ciscoRoomKitMiniLabel.Text = "Cisco Room Kit Mini:";
            // 
            // toplamLabel1
            // 
            this.toplamLabel1.AutoSize = true;
            this.toplamLabel1.Location = new System.Drawing.Point(200, 123);
            this.toplamLabel1.Name = "toplamLabel1";
            this.toplamLabel1.Size = new System.Drawing.Size(45, 13);
            this.toplamLabel1.TabIndex = 8;
            this.toplamLabel1.Text = "Toplam:";
            // 
            // roomKitEQLabel
            // 
            this.roomKitEQLabel.AutoSize = true;
            this.roomKitEQLabel.Location = new System.Drawing.Point(37, 123);
            this.roomKitEQLabel.Name = "roomKitEQLabel";
            this.roomKitEQLabel.Size = new System.Drawing.Size(100, 13);
            this.roomKitEQLabel.TabIndex = 9;
            this.roomKitEQLabel.Text = "Cisco Room Kit EQ:";
            // 
            // roomBarLabel
            // 
            this.roomBarLabel.AutoSize = true;
            this.roomBarLabel.Location = new System.Drawing.Point(200, 94);
            this.roomBarLabel.Name = "roomBarLabel";
            this.roomBarLabel.Size = new System.Drawing.Size(86, 13);
            this.roomBarLabel.TabIndex = 10;
            this.roomBarLabel.Text = "Cisco Room Bar:";
            // 
            // bimLabel
            // 
            this.bimLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bimLabel.AutoSize = true;
            this.bimLabel.Location = new System.Drawing.Point(935, 94);
            this.bimLabel.Name = "bimLabel";
            this.bimLabel.Size = new System.Drawing.Size(97, 13);
            this.bimLabel.TabIndex = 14;
            this.bimLabel.Text = "İdare Mahkemeleri:";
            // 
            // bamLabel
            // 
            this.bamLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bamLabel.AutoSize = true;
            this.bamLabel.Location = new System.Drawing.Point(935, 65);
            this.bamLabel.Name = "bamLabel";
            this.bamLabel.Size = new System.Drawing.Size(125, 13);
            this.bamLabel.TabIndex = 13;
            this.bamLabel.Text = "Bölge Adliye Makemeleri:";
            // 
            // savcilikLabel
            // 
            this.savcilikLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.savcilikLabel.AutoSize = true;
            this.savcilikLabel.Location = new System.Drawing.Point(935, 39);
            this.savcilikLabel.Name = "savcilikLabel";
            this.savcilikLabel.Size = new System.Drawing.Size(47, 13);
            this.savcilikLabel.TabIndex = 12;
            this.savcilikLabel.Text = "Savcılık:";
            // 
            // cezaMahLabel
            // 
            this.cezaMahLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cezaMahLabel.AutoSize = true;
            this.cezaMahLabel.Location = new System.Drawing.Point(935, 11);
            this.cezaMahLabel.Name = "cezaMahLabel";
            this.cezaMahLabel.Size = new System.Drawing.Size(97, 13);
            this.cezaMahLabel.TabIndex = 11;
            this.cezaMahLabel.Text = "Ceza Mahkemeleri:";
            // 
            // cikLabel
            // 
            this.cikLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cikLabel.AutoSize = true;
            this.cikLabel.Location = new System.Drawing.Point(935, 123);
            this.cikLabel.Name = "cikLabel";
            this.cikLabel.Size = new System.Drawing.Size(106, 13);
            this.cikLabel.TabIndex = 18;
            this.cikLabel.Text = "Ceza İnfaz Kurumları:";
            // 
            // yuksekYargiLabel
            // 
            this.yuksekYargiLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.yuksekYargiLabel.AutoSize = true;
            this.yuksekYargiLabel.Location = new System.Drawing.Point(1142, 65);
            this.yuksekYargiLabel.Name = "yuksekYargiLabel";
            this.yuksekYargiLabel.Size = new System.Drawing.Size(73, 13);
            this.yuksekYargiLabel.TabIndex = 17;
            this.yuksekYargiLabel.Text = "Yüksek Yargı:";
            // 
            // gtLabel
            // 
            this.gtLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gtLabel.AutoSize = true;
            this.gtLabel.Location = new System.Drawing.Point(1142, 39);
            this.gtLabel.Name = "gtLabel";
            this.gtLabel.Size = new System.Drawing.Size(25, 13);
            this.gtLabel.TabIndex = 16;
            this.gtLabel.Text = "GT:";
            // 
            // agoLabel
            // 
            this.agoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.agoLabel.AutoSize = true;
            this.agoLabel.Location = new System.Drawing.Point(1142, 11);
            this.agoLabel.Name = "agoLabel";
            this.agoLabel.Size = new System.Drawing.Size(33, 13);
            this.agoLabel.TabIndex = 15;
            this.agoLabel.Text = "AGO:";
            // 
            // hskLabel
            // 
            this.hskLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hskLabel.AutoSize = true;
            this.hskLabel.Location = new System.Drawing.Point(1142, 94);
            this.hskLabel.Name = "hskLabel";
            this.hskLabel.Size = new System.Drawing.Size(32, 13);
            this.hskLabel.TabIndex = 19;
            this.hskLabel.Text = "HSK:";
            // 
            // toplamLabel2
            // 
            this.toplamLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toplamLabel2.AutoSize = true;
            this.toplamLabel2.Location = new System.Drawing.Point(1143, 123);
            this.toplamLabel2.Name = "toplamLabel2";
            this.toplamLabel2.Size = new System.Drawing.Size(45, 13);
            this.toplamLabel2.TabIndex = 20;
            this.toplamLabel2.Text = "Toplam:";
            // 
            // excelExportBtn
            // 
            this.excelExportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.excelExportBtn.Location = new System.Drawing.Point(1188, 147);
            this.excelExportBtn.Name = "excelExportBtn";
            this.excelExportBtn.Size = new System.Drawing.Size(136, 32);
            this.excelExportBtn.TabIndex = 21;
            this.excelExportBtn.Text = "EXCELE AKTAR";
            this.excelExportBtn.UseVisualStyleBackColor = true;
            this.excelExportBtn.Click += new System.EventHandler(this.excelExportBtn_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(39, 637);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(975, 23);
            this.progressBar1.TabIndex = 23;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 641);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1369, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // labelLoading
            // 
            this.labelLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLoading.AutoSize = true;
            this.labelLoading.Location = new System.Drawing.Point(1020, 644);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(65, 13);
            this.labelLoading.TabIndex = 24;
            this.labelLoading.Text = "Yükleniyor...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 663);
            this.Controls.Add(this.labelLoading);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.excelExportBtn);
            this.Controls.Add(this.toplamLabel2);
            this.Controls.Add(this.hskLabel);
            this.Controls.Add(this.cikLabel);
            this.Controls.Add(this.yuksekYargiLabel);
            this.Controls.Add(this.gtLabel);
            this.Controls.Add(this.agoLabel);
            this.Controls.Add(this.bimLabel);
            this.Controls.Add(this.bamLabel);
            this.Controls.Add(this.savcilikLabel);
            this.Controls.Add(this.cezaMahLabel);
            this.Controls.Add(this.roomBarLabel);
            this.Controls.Add(this.roomKitEQLabel);
            this.Controls.Add(this.toplamLabel1);
            this.Controls.Add(this.ciscoRoomKitMiniLabel);
            this.Controls.Add(this.ciscoRoomKitProLabel);
            this.Controls.Add(this.ciscoSX80Label);
            this.Controls.Add(this.ciscoSX20Label);
            this.Controls.Add(this.ciscoMX200Label);
            this.Controls.Add(this.ciscoEX90Label);
            this.Controls.Add(this.ciscoC60Label);
            this.Controls.Add(this.dataGridAllPhones);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SEGBİS APP";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllPhones)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAllPhones;
        private Label ciscoC60Label;
        private Label ciscoEX90Label;
        private Label ciscoMX200Label;
        private Label ciscoSX20Label;
        private Label ciscoSX80Label;
        private Label ciscoRoomKitProLabel;
        private Label ciscoRoomKitMiniLabel;
        private Label toplamLabel1;
        private Label roomKitEQLabel;
        private Label roomBarLabel;
        private Label bimLabel;
        private Label bamLabel;
        private Label savcilikLabel;
        private Label cezaMahLabel;
        private Label cikLabel;
        private Label yuksekYargiLabel;
        private Label gtLabel;
        private Label agoLabel;
        private Label hskLabel;
        private Label toplamLabel2;
        private Button excelExportBtn;
        private ProgressBar progressBar1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private StatusStrip statusStrip1;
        private Label labelLoading;
    }
}

